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

namespace MobyShop.WinUI.Dobavljaci
{
    public partial class frmDobavljaciDetalji : Form
    {
        APIService _service = new APIService("dobavljaci");
        private int? _id = null;
        public frmDobavljaciDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var request = new DobavljaciInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    KontaktOsoba = txtKontaktOsoba.Text,
                    Adresa = txtAdresa.Text,
                    Telefon = txtTelefon.Text,
                    Fax = txtFax.Text,
                    Web = txtWeb.Text,
                    Email = txtEmail.Text,
                    ZiroRacuni = txtZiroRacuni.Text,
                    Napomena = txtNapomena.Text,
                    Status = txtStatus.Checked
                };
                _service.Insert<Models.Dobavljaci>(request);
                MessageBox.Show("Uspješno dodan Dobavljac");
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
                Validator.ValidirajKontrolu(txtNaziv, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtKontaktOsoba, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtAdresa, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtTelefon, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtEmail, err, "Obavezna vrijednost");
        }
    }
}
