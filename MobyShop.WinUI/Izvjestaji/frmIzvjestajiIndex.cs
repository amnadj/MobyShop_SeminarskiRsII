using MobyShop.Model.Requests;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI.Izvjestaji
{
    public partial class frmIzvjestajiIndex : Form
    {
        private readonly APIService _serviceArtikli = new APIService("Artikli");
        private readonly APIService _serviceNarudzbeStavke = new APIService("StavkeNarudzbe");
        private readonly APIService _serviceNarudzbe = new APIService("Narudzbe");
        public frmIzvjestajiIndex()
        {
            InitializeComponent();
        }

        private async void btnArtikli_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = false;
            dtpDatumOd.Enabled = false;
            txtPretraga.Enabled = false;
            btnPretraga.Enabled = false;

            List<ProdaniArtikli> prodani = new List<ProdaniArtikli>();

            List<Models.Artikli> listaArtikala = await _serviceArtikli.Get<List<Models.Artikli>>(null);

            List<StavkeNarudzbe> listaNarudzbi = await _serviceNarudzbeStavke.Get<List<StavkeNarudzbe>>(null);

            foreach (var item1 in listaNarudzbi)
            {

                foreach (var item2 in listaArtikala)
                {
                    if (item1.ArtikalId == item2.ArtikalId)
                    {

                        ProdaniArtikli novi = new ProdaniArtikli
                        {

                            Cijena = item1.Cijena,
                            Kolicina = item1.Kolicina,
                            Naziv = item2.Naziv,
                            Sifra = item2.Sifra,
                            Ukupno = item1.Kolicina * item1.Cijena
                        };
                        var postoji = false;
                        foreach (var item3 in prodani)
                        {
                            if (item3.Naziv.Equals(novi.Naziv))
                            {
                                postoji = true;
                                item3.Kolicina += novi.Kolicina;
                                item3.Ukupno += item3.Cijena * novi.Kolicina;
                            }
                        }
                        if (postoji == false)
                        {
                            prodani.Add(novi);
                        }
                    }

                }
            }

            dataGridView1.DataSource = prodani;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            if (dtpDatumDo.Enabled == true && dtpDatumOd.Enabled == true && txtPretraga.Enabled == true)
            {
                var search = new NarudzbeSearchRequest()
                {
                    BrojNarudzbe = txtPretraga.Text
                };

                var listaNarudzbi = await _serviceNarudzbe.Get<List<Models.Narudzbe>>(search);
                List<NarudzbeIzvjestaj> result = new List<NarudzbeIzvjestaj>();

                foreach (var item in listaNarudzbi)
                {
                    if (dtpDatumOd.Value < item.Datum && item.Datum < dtpDatumDo.Value)
                    {
                        result.Add(new NarudzbeIzvjestaj
                        {
                            BrojNarudzbe = item.BrojNarudzbe,
                            Datum = item.Datum,
                            IznosBezPdv = item.IznosBezPdv,
                            IznosSaPdv = item.IznosSaPdv
                        });
                    }
                }
                dataGridView1.DataSource = result;
            }
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = true;
            dtpDatumOd.Enabled = true;

            txtPretraga.Enabled = true;
            btnPretraga.Enabled = true;

            dataGridView1.DataSource = null;

            txtPretraga.Text = "";
        }
        Bitmap bmp;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }
    }
}
