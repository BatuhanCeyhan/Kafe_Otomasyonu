using Core.CrossCuttingConcern.Utility;
using kafe.WinUI.Personel;
using kafe.WinUI;
using Kafe.Bussinuss.Abstract;
using Kafe.Bussinuss.Concrete;
using Kafe.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kafe.WinUI.Urunler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kafe.Urunler
{
    public partial class UserUrunIslemleri : UserControl
    {
        public Urun Urun1 { get; set; }
        IUrunBs UrunBs;

        string photopath;
        public UserUrunIslemleri(IUrunBs _urunBs)
        {
            this.Load += UserUrunIslemleri_Load;
            UrunBs = _urunBs;
            InitializeComponent();

        }
        public void VerileriCekme()
        {

            dataGridView1.DataSource = UrunBs.GetAll();


        }

        private void UserUrunIslemleri_Load(object sender, EventArgs e)
        {
            VerileriCekme();

            if (Urun1 != null)
            {

                switch (Urun1.KategoriID)
                {
                    case 1: cmbUrunSinifi.Text = "Soğuk İçecek"; break;
                    case 2: cmbUrunSinifi.Text = " Meşrubat"; break;
                    case 3: cmbUrunSinifi.Text = "Kahveler"; break;
                    case 4: cmbUrunSinifi.Text = "Sıcak İçecekler"; break;
                    case 5: cmbUrunSinifi.Text = "Tatlılar"; break;
                    case 6: cmbUrunSinifi.Text = "Sandviç"; break;

                    default:
                        MessageBox.Show("Lütfen Ürün Sınıfını Giriniz");
                        break;
                }
                cmbUrunBoyutu.Text = Urun1.UrunBoyutu;
                txtUrunAdi.Text = Urun1.UrunAdi;
                txtNasilYapilir.Text = Urun1.NasilYapilir;
                txtUcret.Text = Urun1.Ucreti.ToString();
                pbfotograf.ImageLocation = Application.StartupPath + Urun1.Resim;
                btnKaydet.Text = "Güncelle";
            }
            else
            {
                btnKaydet.Text = "Kaydet";
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Urun1 == null)
            {
                Urun UrunEkleme = new Urun();
                switch (cmbUrunSinifi.Text)
                {
                    case "Soğuk İçecek": UrunEkleme.KategoriID = 1; break;
                    case "Meşrubat": UrunEkleme.KategoriID = 2; break;
                    case "Kahveler": UrunEkleme.KategoriID = 3; break;
                    case "Sıcak İçecekler": UrunEkleme.KategoriID = 4; break;
                    case "Tatlılar": UrunEkleme.KategoriID = 5; break;
                    case "Sandviç": UrunEkleme.KategoriID = 6; break;

                    default:
                        MessageBox.Show("Lütfen Ürün Sınıfını Giriniz");
                        break;
                }

                UrunEkleme.UrunBoyutu = cmbUrunBoyutu.Text;
                UrunEkleme.UrunAdi = txtUrunAdi.Text;
                UrunEkleme.Ucreti = Convert.ToDecimal(txtUcret.Text);
                UrunEkleme.NasilYapilir = txtNasilYapilir.Text;
                UrunEkleme.Resim = photopath;
               
                UrunBs.Insert(UrunEkleme);
                VerileriCekme();
                MessageBox.Show("Ürün Başarı İle Eklendi");
            }
            else
            {
                Urun UrunGuncelle = Urun1;

                switch (cmbUrunSinifi.Text)
                {
                    case "Soğuk İçecek": UrunGuncelle.KategoriID = 1; break;
                    case "Meşrubat": UrunGuncelle.KategoriID = 2; break;
                    case "Kahveler": UrunGuncelle.KategoriID = 3; break;
                    case "Sıcak İçecekler": UrunGuncelle.KategoriID = 4; break;
                    case "Tatlılar": UrunGuncelle.KategoriID = 5; break;
                    case "Sandviç": UrunGuncelle.KategoriID = 6; break;

                    default:
                        MessageBox.Show("Lütfen Ürün Sınıfını Giriniz");
                        break;
                }

                UrunGuncelle.UrunBoyutu = cmbUrunBoyutu.Text;
                UrunGuncelle.UrunAdi = txtUrunAdi.Text;
                UrunGuncelle.Ucreti = Convert.ToDecimal(txtUcret.Text);
                UrunGuncelle.NasilYapilir = txtNasilYapilir.Text;
                UrunGuncelle.Resim = photopath;
                UrunBs.Update(UrunGuncelle);
                VerileriCekme();
                MessageBox.Show("Ürün Başarı İle Güncellendi");
            }

        }

        private void btnFotograf_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                string extension = Path.GetExtension(openFileDialog1.FileName).ToLower();
                if (extension == ".jpg" || extension == ".jpge" || extension == ".png")
                {
                    string filename = RandomValueGenerator.GenerateFileName(extension);

                    photopath = "/images/Urun/" + filename;

                    string destination = Application.StartupPath + photopath;

                    File.Copy(openFileDialog1.FileName, destination);

                    pbfotograf.ImageLocation = destination;
                }
                else
                {
                    MessageBox.Show("Lütfen Sadece Resim Seçiniz..");
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Urun Urun1 = dataGridView1.SelectedRows[0].DataBoundItem as Urun;

            if (Urun1 != null)
            {

                DialogResult dr = MessageBox.Show($"{Urun1.UrunAdi}  Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Urun SilinecekUrun = UrunBs.Get(x => x.ID == Urun1.ID);
                    UrunBs.Delete(SilinecekUrun);
                    VerileriCekme();

                    MessageBox.Show("Kayıt Başarı İle Silindi.");
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }

        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun urun = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();
            UserUrunBilgileri userUrunBilgileri = FormFactory.CreateUserUrunBilgileri();
            userUrunBilgileri.Urun = urun;
            panel.Controls.Add(userUrunBilgileri);
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun Urun1 = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();

            userUrunIslemleri.Urun1 = Urun1;
            panel.Controls.Add(userUrunIslemleri);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Urun Urun1 = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();

            userUrunIslemleri.Urun1 = Urun1;
            panel.Controls.Add(userUrunIslemleri);
        }


    }
}
