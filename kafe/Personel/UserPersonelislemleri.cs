using Core.CrossCuttingConcern.Utility;
using Kafe.Bussinuss.Abstract;
using Kafe.Bussinuss.Concrete;
using Kafe.DataAccsess.Abstact;
using Kafe.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe.WinUI.Personel
{

    public partial class UserPersonelislemleri : UserControl
    {
        public Kullanici Personel { get; set; }
        IKullaniciBs girisbs;
        string photopath;

        public UserPersonelislemleri(IKullaniciBs _girisbs)
        {
            this.Load += UserPersonelislemleri_Load;

            girisbs = _girisbs;
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (Personel == null)
            {
                Kullanici PersonelEkleme = new Kullanici();

                if (cmbPersonelId.Text == "Admin")
                {
                    PersonelEkleme.BelirlemeID = 1;
                }
                else
                {
                    PersonelEkleme.BelirlemeID = 2;
                }

                //----------MAAŞ------------------
                if (PersonelEkleme.Maas==null)
                {
                    PersonelEkleme.Maas = 0;
                }
                else
                {
                    PersonelEkleme.Maas = Convert.ToDecimal(txtPersonelMaas.Text);
                }
                //-----------------------------------
                PersonelEkleme.Adi = txtPersonelAdi.Text;
                PersonelEkleme.Soyadi = txtPersonelSoyadi.Text;
                PersonelEkleme.KullaniciAdi = txtPersonelKullanici.Text;
                PersonelEkleme.Sifre = txtPersonelSifre.Text;
                PersonelEkleme.Resim = photopath;
                PersonelEkleme.Notlar = txtPersonelNotlar.Text;
                PersonelEkleme.IseBaslamaTarihi = dtpPersonelIseBaslama.Value;


                girisbs.Insert(PersonelEkleme);
                VerileriAl();

                MessageBox.Show("Kullanıcı Kaydoldu");
            }
            else
            {
                Kullanici personelGuncelleme = Personel;

                if (cmbPersonelId.Text == "Admin")
                {
                    personelGuncelleme.BelirlemeID = 1;
                }
                else
                {
                    personelGuncelleme.BelirlemeID = 2;
                }

                personelGuncelleme.Adi = txtPersonelAdi.Text;
                personelGuncelleme.Soyadi = txtPersonelSoyadi.Text;
                personelGuncelleme.KullaniciAdi = txtPersonelKullanici.Text;
                personelGuncelleme.Sifre = txtPersonelSifre.Text;
                personelGuncelleme.Resim = photopath;
                personelGuncelleme.Notlar = txtPersonelNotlar.Text;
                personelGuncelleme.Maas = Convert.ToDecimal(txtPersonelMaas.Text);
                personelGuncelleme.IseBaslamaTarihi = dtpPersonelIseBaslama.Value;

                girisbs.Update(personelGuncelleme);
                VerileriAl();

                MessageBox.Show("Personel Güncellenmiştir");

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

                    photopath = "/images/personel/" + filename;

                    string destination = Application.StartupPath + photopath;

                    File.Copy(openFileDialog1.FileName, destination);

                    pbFotograf.ImageLocation = destination;
                }
                else
                {
                    MessageBox.Show("Lütfen Sadece Resim Seçiniz..");
                }

            }
        }


        private void UserPersonelislemleri_Load(object sender, EventArgs e)
        {
            VerileriAl();

            if (Personel == null)
            {
                btnKaydet.Text = "Kaydet";
            }
            else
            {

                if (Personel.BelirlemeID == 1)
                {
                    cmbPersonelId.Text = "Admin";
                }
                else
                {
                    cmbPersonelId.Text = "Personel";
                }

                txtPersonelAdi.Text = Personel.Adi;
                txtPersonelKullanici.Text = Personel.KullaniciAdi;
                txtPersonelMaas.Text = Convert.ToString(Personel.Maas);
                txtPersonelNotlar.Text = Personel.Notlar;
                txtPersonelSifre.Text = Personel.Sifre;
                txtPersonelSoyadi.Text = Personel.Soyadi;
                pbFotograf.ImageLocation = Application.StartupPath + Personel.Resim;
                dtpPersonelIseBaslama.Text = Convert.ToString(Personel.IseBaslamaTarihi);

                btnKaydet.Text = "Güncelle";
                lblPersonel.Text = "Personel Güncelleme";
            }

        }

        public void VerileriAl()
        {
            dataGridView1.DataSource = girisbs.GetAll();
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[3].Visible=false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanici Personel = dataGridView1.SelectedRows[0].DataBoundItem as Kullanici;

            if (Personel != null)
            {

                DialogResult dr = MessageBox.Show($"{Personel.Adi} {Personel.Soyadi} Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Kullanici SilinecekPersonel = girisbs.Get(x => x.ID == Personel.ID);
                    girisbs.Delete(SilinecekPersonel);
                    VerileriAl();

                    MessageBox.Show("Kayıt Başarı İle Silindi.");
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Kullanici Personel = dataGridView1.SelectedRows[0].DataBoundItem as Kullanici;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserPersonelislemleri userPersonelislemleri = FormFactory.CreateUserPersonelislemleri();

            userPersonelislemleri.Personel = Personel;
            panel.Controls.Add(userPersonelislemleri);

        }

        private void bilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanici Personel = dataGridView1.SelectedRows[0].DataBoundItem as Kullanici;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();
            UserPersonelBilgi userPersonelBilgi = FormFactory.CreatUserPersonelBilgisi();
            userPersonelBilgi.PersonelBilgi = Personel;
            panel.Controls.Add(userPersonelBilgi);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Kullanici Personel = dataGridView1.SelectedRows[0].DataBoundItem as Kullanici;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserPersonelislemleri userPersonelislemleri = FormFactory.CreateUserPersonelislemleri();

            userPersonelislemleri.Personel = Personel;
            panel.Controls.Add(userPersonelislemleri);
        }



    }
}
