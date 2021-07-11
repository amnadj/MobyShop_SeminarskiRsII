using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI.Artikli
{
    public partial class frmArtikliDetalji : Form
    {
        private readonly APIService _modeli = new APIService("Modeli");
        private readonly APIService _karakteristike = new APIService("Karakteristike");
        private readonly APIService _proizvodjaci = new APIService("Proizvodjaci");
        private readonly APIService _artikli = new APIService("Artikli");
        ArtikliInsertRequest request = new ArtikliInsertRequest();
        private int? _id = null;
        public frmArtikliDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmArtikliDetalji_Load(object sender, EventArgs e)
        {
            await LoadModeli();
            await LoadProizvodjaci();

            if (_id.HasValue)
            {
                var entity = await _artikli.GetById<Models.Artikli>(_id);
                txtNaziv.Text = entity.Naziv;
                txtSifra.Text = entity.Sifra;
                txtCijena.Text = Convert.ToString(entity.Cijena);
                if (entity.Status == true) { checkBoxStatus.Checked = true; }
                comboBoxModel.SelectedIndex = entity.ModelId;
                comboBoxProizvodjac.SelectedIndex = entity.ProizvodjacId;
                pictureBoxSlika.Image = byteArrayToImage(entity.SlikaThumb);

                var k = await _karakteristike.GetById<Models.Karakteristike>(entity.KarakteristikeId);
                if (k.Novo == true) { checkBox_Stanje.Checked = true; }
                txtOperatovniSistem.Text = k.OperativniSistem;
                txtKamera.Text = Convert.ToString(k.Kamera);
                txtRam.Text = Convert.ToString(k.Ram);
                txtMemorija.Text = Convert.ToString(k.Memorija);
                txtProcesor.Text = Convert.ToString(k.Procesor);

            }
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaci.Get<List<Models.Proizvodjaci>>(null);
            result.Insert(0, new Models.Proizvodjaci());

            comboBoxProizvodjac.DataSource = result;
            comboBoxProizvodjac.DisplayMember = "Naziv";
            comboBoxProizvodjac.ValueMember = "ProizvodjacId";
        }

        private async Task LoadModeli()
        {
            var result = await _modeli.Get<List<Models.Modeli>>(null);
            result.Insert(0, new Models.Modeli());
            comboBoxModel.DataSource = result;
            comboBoxModel.DisplayMember = "Naziv";
            comboBoxModel.ValueMember = "ModelId";
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                thumb.Save(Path.ChangeExtension(fileName, "thumb"));


                request.SlikaThumb = ImageToByteArray(thumb);


                pictureBoxSlika.Image = thumb;
            }
        }

        public static byte[] ImageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Cijena = Convert.ToDecimal(txtCijena.Text);
            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;
            request.Status = checkBoxStatus.Checked;

            if (pictureBoxSlika.Image != null)
            {
                Image i = pictureBoxSlika.Image;
                request.Slika = ImageToByteArray(i);

                Image thumb = i.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);


                request.SlikaThumb = ImageToByteArray(thumb);

            }

            KarakteristikeInsertRequest k = new KarakteristikeInsertRequest();
            k.Kamera = Convert.ToDecimal(txtKamera.Text);
            k.Memorija = Convert.ToDecimal(txtMemorija.Text);
            k.Novo = checkBox_Stanje.Checked;
            k.OperativniSistem = txtOperatovniSistem.Text;
            k.Procesor = Convert.ToDecimal(txtProcesor.Text);
            k.Ram = Convert.ToDecimal(txtRam.Text);

            _karakteristike.Insert<Models.Karakteristike>(k);


            var result = await _karakteristike.Get<List<Models.Karakteristike>>(null);

            int id = result.Max(x => x.KarakteristikeId);

            request.KarakteristikeId = id;

            var idProizvodjac = comboBoxProizvodjac.SelectedValue;

            if (int.TryParse(idProizvodjac.ToString(), out int _idProizvodjac))
            {
                request.ProizvodjacId = _idProizvodjac;
            }

            var idModel = comboBoxModel.SelectedValue;

            if (int.TryParse(idModel.ToString(), out int _ModelId))
            {
                request.ModelId = _ModelId;
            }

            if (!_id.HasValue)
            {
                _artikli.Insert<Models.Artikli>(request);
                MessageBox.Show("Uspješno dodan artikal");
            }
            else
            {
                _artikli.Update<Models.Artikli>(_id.Value, request);
                MessageBox.Show("Uspješno izmjenjeni podaci o artiklu");
            }

            Form.ActiveForm.Close();
        }

        public bool ByteArrayToFileName(string fileName, byte[] byteArray)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(byteArray, 0, byteArray.Length);
                return true;
            }
        }
    }
}
