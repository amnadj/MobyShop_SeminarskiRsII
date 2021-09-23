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
        private readonly APIService _servicePracenje = new APIService("NarudzbePracenjeInfo");
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
            cmbSkladista.SelectedValue = narudzba.SkladisteId;

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

            var pracenje = await _servicePracenje.Get<List<Models.NarudzbePracenjeInfo>>(new Model.Requests.NarudzbePracenjeInfoSearchRequest
            {
                NarudzbaId = _id
            });

            if (narudzba.Otkazano == false)
            {
                if (pracenje.Any(x => x.StatusPracenja == Models.StatusPracenja.Potvrđena) && !pracenje.Any(x => x.StatusPracenja == Models.StatusPracenja.Poslana))
                {
                    btnNarudzbaPoslana.Enabled = true;
                }
            }
        }

        private async void btnNarudzbaPoslana_Click(object sender, EventArgs e)
        {
            if(cmbSkladista.SelectedItem == null || (cmbSkladista.SelectedItem as Models.Skladista).SkladisteId == 0)
            {
                MessageBox.Show("Odaberite skladište.");
                return;
            }

            Models.Narudzbe narudzba = await _serviceNarudzbe.GetById<Models.Narudzbe>(_id);
            if(narudzba.Otkazano.HasValue && narudzba.Otkazano.Value)
            {
                MessageBox.Show("Narudžba je otkazana.");
                return;
            }

            var pracenje = await _servicePracenje.Get<List<Models.NarudzbePracenjeInfo>>(new Model.Requests.NarudzbePracenjeInfoSearchRequest
            {
                NarudzbaId = _id
            });

            if (pracenje.Any(x => x.StatusPracenja == Models.StatusPracenja.Potvrđena) && !pracenje.Any(x => x.StatusPracenja == Models.StatusPracenja.Poslana))
            {
                _servicePracenje.Insert<Models.NarudzbePracenjeInfo>(new Model.Requests.NarudzbePracenjeInfoInsertRequest
                {
                    NarudzbaId = _id,
                    Datum = DateTime.Now,
                    StatusPracenja = Models.StatusPracenja.Poslana
                });

                btnNarudzbaPoslana.Enabled = false;

                if (narudzba.SkladisteId == 1 || narudzba.KorisnikId == 1)
                {
                    ZakljuciNarudzbu(narudzba);
                }

                 MessageBox.Show("Uspješno promijenjeno stanje narudžbe.");
            }
            else
            {
                MessageBox.Show("Greška: narudžba nije u ispravnom stanju (nije potvđena ili je već poslana).");
            }
        }

        private void ZakljuciNarudzbu(Models.Narudzbe narudzba)
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
        }
    }
}
