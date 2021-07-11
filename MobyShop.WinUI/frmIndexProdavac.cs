using MobyShop.WinUI.Izvjestaji;
using MobyShop.WinUI.Nabavke;
using MobyShop.WinUI.Narudzbe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace MobyShop.WinUI
{
    public partial class frmIndexProdavac : Form
    {
        private readonly APIService _service = new APIService("PoslanaNarudzba");
        private readonly APIService _serviceNarudzba = new APIService("Narudzbe");

        private int Id = 0;
        public frmIndexProdavac()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            NabavkeSubMenuPanel.Visible = false;
            NarudzbeSubMenuPanel.Visible = false;
            IzvjestajiSubMenuPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNabavke_Click(object sender, EventArgs e)
        {
            showSubMenu(NabavkeSubMenuPanel);
        }

        private void btnDetaljiNabavke_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNabavke());

            hideSubMenu();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNovaNabavka_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNovaNabavka());

            hideSubMenu();
        }

        private async void frmIndexProdavac_Load(object sender, EventArgs e)
        {
            var lista = await _service.Get<List<Models.PoslanaNarudzba>>(null);


            List<Models.PoslanaNarudzba> result = new List<Models.PoslanaNarudzba>();


            foreach (var item in lista)
            {
                if (item.KorisnikId == Global.PrijavljeniKorisnik.KorisnikId)
                {
                    if (item.Poslano == false)
                    {
                        result.Add(item);

                        var search = new Model.Requests.PoslanaNarudzbaUpdateRequest()
                        {
                            Poslano = true

                        };

                        _service.Update<Models.PoslanaNarudzba>(item.PoslanaNarudzbaId, search);

                    }
                }

            }

            foreach (var notifikacija in result)
            {
                if (notifikacija.KorisnikId == Global.PrijavljeniKorisnik.KorisnikId)
                {
                    Models.Narudzbe Narudzba = await _serviceNarudzba.GetById<Models.Narudzbe>(notifikacija.NarudzbaId);

                    Id = Narudzba.NarudzbaId;

                    PopupNotifier popup = new PopupNotifier();
                    popup.AnimationDuration = 6000;
                    popup.Image = Properties.Resources.Info;
                    popup.TitleText = "Notifikacija o narudzbi                         " + notifikacija.Datum.ToShortDateString();
                    popup.ContentText = "Narudzba sa brojem narudzbe '" + Narudzba.BrojNarudzbe + "' je pristigla na odrediste!";
                    popup.ShowOptionsButton = true;
                    popup.OptionsMenu = options;
                    popup.ShowCloseButton = true;


                    popup.Popup();

                }
            }
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            showSubMenu(NarudzbeSubMenuPanel);
        }

        private void btnListaNarudzbi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNarudzbe());

            hideSubMenu();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            showSubMenu(IzvjestajiSubMenuPanel);
        }

        private void btnPregledIzvjestaja_Click(object sender, EventArgs e)
        {
            openChildForm(new frmIzvjestajiIndex());

            hideSubMenu();
        }
    }
}
