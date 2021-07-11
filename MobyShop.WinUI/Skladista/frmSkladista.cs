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

namespace MobyShop.WinUI.Skladista
{
    public partial class frmSkladista : Form
    {
        APIService _service = new APIService("skladista");

        public frmSkladista()
        {
            InitializeComponent();
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            var search = new SkladistaSearchRequest()
            {
                Naziv = txtPretraga.Text,


            };

            var result = await _service.Get<List<Models.Skladista>>(search);
            dgvSkladista.DataSource = result;
        }
    }
}
