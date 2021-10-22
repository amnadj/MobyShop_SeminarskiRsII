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


namespace MobyShop.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _serviceuloge = new APIService("Uloge");
        Uloge admin = null;
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            Models.Korisnici korisnik = await _service.Authenticiraj<Models.Korisnici>(txtKorisnickoIme.Text, txtPassword.Text);
            int ulogaId1 = 0;



            if (korisnik != null)
            {
                Global.PrijavljeniKorisnik = korisnik;
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtPassword.Text;

                foreach (var item in Global.PrijavljeniKorisnik.KorisniciUloge)
                {
                    ulogaId1 = item.UlogaId;

                }
                admin = await _serviceuloge.ProvjeriAdmin<Uloge>(ulogaId1);


                if (admin != null)
                {
                    Global.Admin = true;
                }



                MessageBox.Show("Dobrodosli " + korisnik.Ime + " " + korisnik.Prezime);
                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                MessageBox.Show("Pogresan username ili password", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
