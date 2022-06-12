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

namespace MobyShop.WinUI.Klijenti
{
    public partial class frmKlijenti : Form
    {
        APIService _service = new APIService("klijenti");

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new KlijentiSearchRequest()
            {
                Ime = txtPretraga.Text,


            };

            var result = await _service.Get<List<Models.Klijenti>>(search);
            dgvKlijenti.DataSource = result;
        }

        private async void dgvKlijenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnikId = dgvKlijenti.Rows[e.RowIndex].Cells[0].Value;

            frmKlijentiDetalji frm = new frmKlijentiDetalji(int.Parse(korisnikId.ToString()));
            frm.ShowDialog();
            var result = await _service.Get<List<Models.Klijenti>>(null);
            dgvKlijenti.DataSource = result;
        }
    }
}
