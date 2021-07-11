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
    public partial class frmNarudzbe : Form
    {
        private readonly APIService _service = new APIService("Narudzbe");

        public frmNarudzbe()
        {
            InitializeComponent();
        }

        private void frmNarudzbe_Load(object sender, EventArgs e)
        {
            dgvNarudzbe.AutoGenerateColumns = false;

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = txtPretraga.Text

            };


            var result = await _service.Get<List<Models.Narudzbe>>(search);

            dgvNarudzbe.DataSource = result;
        }

        private void dgvNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int NarudzbaId = Convert.ToInt32(dgvNarudzbe.Rows[dgvNarudzbe.CurrentRow.Index].Cells[0].Value);
                frmNarudzbeDetalji frm = new frmNarudzbeDetalji(NarudzbaId);
                frm.Show();
            }
        }
    }
}
