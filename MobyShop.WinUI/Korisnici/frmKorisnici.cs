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
using MobyShop.Models;


namespace MobyShop.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        APIService _service = new APIService("korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            dgvKorisnici.AutoGenerateColumns = false;
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text,
            };

            var result = await _service.Get<List<Models.Korisnici>>(search);

            dgvKorisnici.DataSource = result;
        }

        private async void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnikId = dgvKorisnici.Rows[e.RowIndex].Cells[0].Value;

            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(korisnikId.ToString()));
            frm.ShowDialog();
            var result = await _service.Get<List<Models.Korisnici>>(null);

            dgvKorisnici.DataSource = result;
        }
        
    }
}
