using MobyShop.Model.Requests;
using MobyShop.WinUI.Artikli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI.Nabavke
{
    public partial class frmNovaNabavka : Form
    {
        private readonly APIService _serviceDobavljaci = new APIService("Dobavljaci");

        private readonly APIService _serviceSkladista = new APIService("Skladista");
        private readonly APIService _serviceArtikli = new APIService("Artikli");
        private readonly APIService _serviceNabavke = new APIService("Nabavke");

        private NabavkeInsertRequest request = new NabavkeInsertRequest();

        private decimal Iznos = 0;
        private const decimal Pdv = 0.17M;
        private decimal IznosPdv = 0;
        public frmNovaNabavka()
        {
            InitializeComponent();
            dgvStavkeNabavke.AutoGenerateColumns = false;
        }

        private async void frmNovaNabavka_Load(object sender, EventArgs e)
        {
            List<Models.Dobavljaci> dobavljaci_result = await _serviceDobavljaci.Get<List<Models.Dobavljaci>>(null);

            dobavljaci_result.Insert(0, new Models.Dobavljaci());
            cmbDobavljaci.DataSource = dobavljaci_result;
            cmbDobavljaci.DisplayMember = "Naziv";
            cmbDobavljaci.ValueMember = "DobavljacId";


            List<Models.Skladista> skladista_result = await _serviceSkladista.Get<List<Models.Skladista>>(null);

            skladista_result.Insert(0, new Models.Skladista());
            cmbSkladista.DataSource = skladista_result;
            cmbSkladista.DisplayMember = "Naziv";
            cmbSkladista.ValueMember = "SkladisteId";
        }

        private void btnListaArtikala_Click(object sender, EventArgs e)
        {
            frmArtikli forma = new frmArtikli();
            forma.Show();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var artikal = !string.IsNullOrWhiteSpace(txtSifra.Text) ? await _serviceArtikli.GetBySifra<Models.Artikli>(txtSifra.Text) : null;

            if (artikal == null)
            {
                MessageBox.Show("Nije pronadjen artikal sa tom sifrom");
                return;
            }

            bool postoji = false;
            foreach (var item in request.stavke)
            {
                if (item.Sifra == artikal.Sifra)
                {
                    MessageBox.Show("Artikal sa ovom sifrom je vec dodan");
                    postoji = true;
                }

            }
            if (postoji == false)
            {
                cmbDobavljaci.Validating -= cmbDobavljaci_Validating;
                cmbSkladista.Validating -= cmbSkladista_Validating;
                txtBrojNabavke.Validating -= txtBrojNabavke_Validating;
                txtNapomena.Validating -= txtNapomena_Validating;

                if (this.ValidateChildren())
                {
                    StavkeNabavkeInsertRequest stavka = new StavkeNabavkeInsertRequest();
                    stavka.ArtikalId = artikal.ArtikalId;
                    stavka.Artikal = artikal.Naziv;
                    stavka.Sifra = artikal.Sifra;
                    stavka.Kolicina = int.Parse(txtKolicina.Text);
                    stavka.Cijena = artikal.Cijena;


                    Iznos += stavka.Cijena * stavka.Kolicina;
                    IznosPdv = Iznos * Pdv;

                    txtIznosRacuna.Text = Math.Round(Iznos + IznosPdv, 2).ToString() + " KM";
                    txtPDV.Text = Math.Round(IznosPdv, 2).ToString() + " KM";



                    request.stavke.Add(stavka);

                    dgvStavkeNabavke.DataSource = request.stavke.ToList();
                }

                cmbDobavljaci.Validating += cmbDobavljaci_Validating;
                cmbSkladista.Validating += cmbSkladista_Validating;
                txtBrojNabavke.Validating += txtBrojNabavke_Validating;
                txtNapomena.Validating += txtNapomena_Validating;


            }
        }

        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            if (request.stavke.Count > 0)
            {
                txtKolicina.Validating -= txtKolicina_Validating;
                if (this.ValidateChildren())
                {

                    request.BrojNabavke = txtBrojNabavke.Text;
                    request.Datum = dtpDatum.Value;
                    request.DobavljacId = int.Parse(cmbDobavljaci.SelectedValue.ToString());
                    request.KorisnikId = Global.PrijavljeniKorisnik.KorisnikId;
                    request.Napomena = txtNapomena.Text;
                    request.SkladisteId = int.Parse(cmbSkladista.SelectedValue.ToString());
                    request.IznosRacuna = Iznos + IznosPdv;
                    request.Pdv = IznosPdv;


                    _serviceNabavke.Insert<Models.Nabavke>(request);

                    MessageBox.Show("Nabavka zakljucena");
                    this.Close();
                }
                txtKolicina.Validating += txtKolicina_Validating;
            }
            else
            {
                MessageBox.Show("Nije moguce zakljuciti nabavku na kojoj ne postoji bar jedan artikal");
            }
        }

        private void cmbSkladista_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSkladista.SelectedIndex == 0 || cmbSkladista.SelectedValue == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbSkladista, "Nije odabrano skladiste");
            }
            else
            {
                errorProvider.SetError(cmbSkladista, null);
            }
        }

        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKolicina, "Količina je obavezna");
            }
            else if (!int.TryParse(txtKolicina.Text, out int val) || val < 1)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKolicina, "Količina nije unesena ispravno");
            }
            else
            {
                errorProvider.SetError(txtKolicina, null);
            }
        }

        private void cmbDobavljaci_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDobavljaci.SelectedIndex == 0 || cmbDobavljaci.SelectedValue == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbDobavljaci, "Nije odabran dobavljač");
            }
            else
            {
                errorProvider.SetError(cmbDobavljaci, null);
            }
        }

        private void txtBrojNabavke_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojNabavke.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojNabavke, "Broj nabavke je obavezan");
            }
            else if (txtBrojNabavke.Text.Length < 4 || !int.TryParse(txtBrojNabavke.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojNabavke, "Broj nabavke mora biti minimalno 4-cifreni broj");
            }
            else
            {
                errorProvider.SetError(txtBrojNabavke, null);
            }
        }

        private void txtNapomena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNapomena, "Napomena je obavezna");
            }
            else if (txtNapomena.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNapomena, "Napomena mora imati minimalno 2 karaktera");
            }
            else
            {
                errorProvider.SetError(txtNapomena, null);
            }
        }
    }
}