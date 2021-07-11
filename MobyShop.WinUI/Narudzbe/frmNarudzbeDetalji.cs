using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI.Narudzbe
{
    public partial class frmNarudzbeDetalji : Form
    {
        private readonly APIService _serviceNarudzbe = new APIService("Narudzbe");
        private readonly APIService _serviceStavke = new APIService("StavkeNarudzbe");
        private readonly APIService _serviceSkladiste = new APIService("Skladista");
        private int _id;

        public frmNarudzbeDetalji(int id)
        {
            InitializeComponent();
            _id = id;
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void frmNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            Models.Narudzbe narudzba = await _serviceNarudzbe.GetById<Models.Narudzbe>(_id);

            txtBrojNarudzbe.Text = narudzba.BrojNarudzbe;
            dtpDatum.Value = narudzba.Datum;
            if (narudzba.Status == true)
            {
                cbStatus.Checked = narudzba.Status;
            }
            if (narudzba.Otkazano == true)
            {
                cbOtkazano.Checked = (bool)narudzba.Otkazano;
            }
            txtIznosbezPdv.Text = narudzba.IznosBezPdv.ToString();
            txtIznossaPdv.Text = narudzba.IznosSaPdv.ToString();

            txtKlijent.Text = narudzba.KlijentKorisnickoIme;

            List<Models.Skladista> skladista_result = await _serviceSkladiste.Get<List<Models.Skladista>>(null);

            skladista_result.Insert(0, new Models.Skladista());
            cmbSkladista.DataSource = skladista_result;
            cmbSkladista.DisplayMember = "Naziv";
            cmbSkladista.ValueMember = "SkladisteId";


            List<Models.StavkeNarudzbe> listastavki = await _serviceStavke.Get<List<Models.StavkeNarudzbe>>(null);

            List<Models.StavkeNarudzbe> result = new List<Models.StavkeNarudzbe>();
            foreach (var item in listastavki)
            {
                Models.StavkeNarudzbe nova = new Models.StavkeNarudzbe();

                if (item.NarudzbaId == narudzba.NarudzbaId)
                {
                    nova.ArtikalId = item.ArtikalId;
                    nova.Cijena = item.Cijena;
                    nova.Kolicina = item.Kolicina;
                    nova.NarudzbaStavkaId = item.NarudzbaStavkaId;
                    nova.Naziv = item.Naziv;
                    nova.Popust = item.Popust;
                    nova.Sifra = item.Sifra;
                    nova.NarudzbaId = item.NarudzbaId;

                    result.Add(nova);
                }
            }

            dataGridView1.DataSource = result;
        }

        private async void btnZakljuci_Click(object sender, EventArgs e)
        {

            Models.Narudzbe narudzba = await _serviceNarudzbe.GetById<Models.Narudzbe>(_id);

            if (narudzba.SkladisteId == 1 || narudzba.KorisnikId == 1)
            {
                var request = new NarudzbeInsertRequest()
                {
                    BrojNarudzbe = narudzba.BrojNarudzbe,
                    Datum = narudzba.Datum,
                    IznosBezPdv = narudzba.IznosBezPdv,
                    IznosSaPdv = narudzba.IznosSaPdv,
                    KlijentId = narudzba.KlijentId,
                    KorisnikId = Global.PrijavljeniKorisnik.KorisnikId,
                    Otkazano = narudzba.Otkazano,
                    SkladisteId = int.Parse(cmbSkladista.SelectedValue.ToString()),
                    Status = narudzba.Status
                };


                _serviceNarudzbe.Update<Models.Narudzbe>(_id, request);

                MessageBox.Show("Uspjesno zakljucena narudzba");
            }
            else
            {
                MessageBox.Show("Narudzba je vec zakljucena");
            }
        }
    }
}
