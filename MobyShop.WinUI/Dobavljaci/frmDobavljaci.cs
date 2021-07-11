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

namespace MobyShop.WinUI.Dobavljaci
{
    public partial class frmDobavljaci : Form
    {
        APIService _service = new APIService("dobavljaci");

        public frmDobavljaci()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new DobavljaciSearchRequest()
            {
                Naziv = txtPretraga.Text
            };

            var result = await _service.Get<List<Models.Dobavljaci>>(search);
            dgvDobavljaci.DataSource = result;
        }
    }
}
