using MobyShop.Model.Requests;
using MobyShop.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        APIService _service = new APIService("klijenti");

        private int? _id = null;
        public frmKlijentiDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;

        }

        private async void FrmKlijentiDetalji_Load(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var entity = await _service.GetById<Models.Korisnici>(_id);
                txtEmail.Text = entity.Email;
                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtTelefon.Text = entity.Telefon;
            }
        }

        private void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                var request = new KlijentiInsertRequest
                {                 
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text
                };

 
                if (!_id.HasValue)
                {
                    _service.Insert<Models.Klijenti>(request);
                    MessageBox.Show("Uspješno dodan klijent");
                    this.Close();
                }
                else
                {
                    _service.Update<Models.Klijenti>(_id.Value, request);
                    MessageBox.Show("Uspješno izmjenjeni podaci o klijentu");
                }
            }
            else
            {
                // ako validacija nije uspijesna
                MessageBox.Show("Unesite  podatke");
            }
        }

        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(txtIme, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtPrezime, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtEmail, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtTelefon, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtKorisnickoIme, err, "Obavezna vrijednost");
        }
    }
}
