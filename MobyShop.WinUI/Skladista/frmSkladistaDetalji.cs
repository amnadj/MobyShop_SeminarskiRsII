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

namespace MobyShop.WinUI.Skladista
{
    public partial class frmSkladistaDetalji : Form
    {
        APIService _service = new APIService("skladista");
        private int? _id = null;
        public frmSkladistaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos()) { 
            var request = new SkladistaInsertRequest
            {
                Naziv = txtNaziv.Text,
                Adresa = txtAdresa.Text,
                Opis = txtOpis.Text
            };
            _service.Insert<Models.Skladista>(request);
            MessageBox.Show("Uspješno dodano skladište");
            }

            else
            {
                MessageBox.Show("Unesite podatke");
            }
        }
    private bool ValidirajUnos()
    {
        return
            Validator.ValidirajKontrolu(txtNaziv, err, "Obavezna vrijednost") &&
            Validator.ValidirajKontrolu(txtAdresa, err, "Obavezna vrijednost");
    }
}
}
