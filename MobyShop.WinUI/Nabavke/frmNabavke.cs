using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobyShop.Models;

namespace MobyShop.WinUI.Nabavke
{
    public partial class frmNabavke : Form
    {
        APIService _service = new APIService("Nabavke");
        APIService _serviceStavke = new APIService("StavkeNabavke");
        public frmNabavke()
        {
            
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            List<Models.Nabavke> Ukupno = await _service.Get<List<Models.Nabavke>>(null);

            List<Models.Nabavke> lista = new List<Models.Nabavke>();

            foreach (var item in Ukupno)
            {
                Models.Nabavke nova = new Models.Nabavke();

                if (dateTimePicker1.Value < item.Datum && item.Datum < dateTimePicker2.Value)
                {
                    nova = item;
                    lista.Add(nova);


                }
            }

            lista.Insert(0, new Models.Nabavke());
            cmbNabavke.DisplayMember = "Napomena";
            cmbNabavke.ValueMember = "NabavkaId";
            cmbNabavke.DataSource = lista;

        }

        private async void cmbNabavke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNabavke.SelectedIndex > 0)
            {
                Models.Nabavke nova = await _service.GetById<Models.Nabavke>(cmbNabavke.SelectedValue);


                txtSkladiste.Text = nova.NazivSkladista;
                txtBrojNabavke.Text = nova.BrojNabavke;
                dtpDatum.Value = nova.Datum;
                txtIznosRacuna.Text = nova.IznosRacuna.ToString() + " KM";
                txtPDV.Text = nova.Pdv.ToString() + " KM";
                txtNapomena.Text = nova.Napomena;
                txtNazivDobavljaca.Text = nova.NazivDobavljaca;
                txtKontaktOsoba.Text = nova.KontaktOsoba;
                txtTelefon.Text = nova.Telefon;

                List<StavkeNabavke> stavke = await _serviceStavke.Get<List<StavkeNabavke>>(null);

                List<StavkeNabavke> result = new List<StavkeNabavke>();

                foreach (var item in stavke)
                {
                    StavkeNabavke stavka = new StavkeNabavke();

                    if (item.NabavkaId == nova.NabavkaId)
                    {
                        stavka.Artikal = item.Artikal;
                        stavka.ArtikalId = item.ArtikalId;
                        stavka.Cijena = item.Cijena;
                        stavka.Kolicina = item.Kolicina;
                        stavka.Model = item.Model;
                        stavka.NabavkaId = item.NabavkaId;
                        stavka.Proizvodjac = item.Proizvodjac;
                        stavka.Slika = item.Slika;
                        stavka.StavkeNabavkeId = item.StavkeNabavkeId;

                        result.Add(stavka);
                    }
                }
                dgvStavkeNabavke.AutoGenerateColumns = false;
                dgvStavkeNabavke.DataSource = result;
            }
            else
            {
                txtSkladiste.Text = "";
                txtBrojNabavke.Text = "";
                dtpDatum.Value = DateTime.Now;
                txtIznosRacuna.Text = "";
                txtPDV.Text = "";
                txtNapomena.Text = "";
                txtNazivDobavljaca.Text = "";
                txtKontaktOsoba.Text = "";
                txtTelefon.Text = "";

                dgvStavkeNabavke.DataSource = null;

            }
        }

        private async void frmNabavke_Load(object sender, EventArgs e)
        {
            List<Models.Nabavke> Ukupno = await _service.Get<List<Models.Nabavke>>(null);

     
                
            cmbNabavke.DataSource = Ukupno;
            cmbNabavke.DisplayMember = "BrojNabavke";
            cmbNabavke.ValueMember = "NabavkaId";

            dgvStavkeNabavke.AutoGenerateColumns = false;
        }

        private void btnDodajNabavku_Click(object sender, EventArgs e)
        {
            frmNovaNabavka forma = new frmNovaNabavka();
            forma.Show();
        }
    }
}
