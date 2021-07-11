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


namespace MobyShop.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        APIService _service = new APIService("korisnici");
        APIService _ulogeService = new APIService("uloge");

        private int? _id = null;
        public frmKorisniciDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var id = _id ?? default(int);

                var ulogeList = await _ulogeService.Get<List<Models.Uloge>>(null);
                var ulogeKorisnik = await _ulogeService.SveUloge<List<Models.KorisniciUloge>>(id);

                clbRole.DataSource = ulogeList;
                clbRole.DisplayMember = "Naziv";



                foreach (var item in ulogeKorisnik)
                {
                    var uloga = ulogeList.Where(x => x.UlogaId == item.UlogaId).First();

                    int index = clbRole.FindString(uloga.Naziv);
                                           
                    clbRole.SetItemCheckState(index, CheckState.Checked);
                  
                }
                

                var entity = await _service.GetById<Models.Korisnici>(_id);
                txtEmail.Text = entity.Email;
                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtTelefon.Text = entity.Telefon;
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var roleList = clbRole.CheckedItems.Cast<Models.Uloge>().Select(x => x.UlogaId).ToList();

                var request = new KorisniciInsertRequest
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text,
                    Uloge = roleList
                };


                if (!_id.HasValue)
                {
                    _service.Insert<Models.Korisnici>(request);
                    MessageBox.Show("Uspješno dodan korisnik");
                }
                else
                {
                    _service.Update<Models.Korisnici>(_id.Value, request);
                    MessageBox.Show("Uspješno izmjenjeni podaci o korisniku");
                }
            }

        }
    }
}
