using Kafe.Bussinuss.Abstract;
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

namespace kafe.WinUI.Personel
{
    public partial class UserPersonelBilgi : UserControl
    {
        public Kullanici PersonelBilgi { get; set; }

        IKullaniciBs KullaniciBs;
        public UserPersonelBilgi(IKullaniciBs _KullaniciBs)
        {
            this.Load += UserPersonelBilgi_Load;

            KullaniciBs = _KullaniciBs;
            InitializeComponent();
        }

        private void UserPersonelBilgi_Load(object sender, EventArgs e)
        {
            if (PersonelBilgi != null)
            {
                txtPersonelAdi.Text = PersonelBilgi.Adi;
                txtPersonelKullanici.Text = PersonelBilgi.KullaniciAdi;
                txtPersonelMaas.Text = Convert.ToString(PersonelBilgi.Maas);
                txtPersonelNotlar.Text = PersonelBilgi.Notlar;
                txtPersonelSifre.Text = PersonelBilgi.Sifre;
                txtPersonelSoyadi.Text = PersonelBilgi.Soyadi;
                dtpPersonelIseBaslama.Value = PersonelBilgi.IseBaslamaTarihi ?? DateTime.Now;
                pbFotograf.ImageLocation = Application.StartupPath + PersonelBilgi.Resim;

                VerileriCekme();
            }

            VerileriCekme();


        }
        public void VerileriCekme()
        {
            dataGridView1.DataSource = KullaniciBs.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanici Personel = dataGridView1.SelectedRows[0].DataBoundItem as Kullanici;

            if (Personel != null)
            {

                DialogResult dr = MessageBox.Show($"{Personel.Adi} {Personel.Soyadi} Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Kullanici SilinecekPersonel = KullaniciBs.Get(x => x.ID == Personel.ID);
                    KullaniciBs.Delete(SilinecekPersonel);
                    VerileriCekme();

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

        private void eKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();

            UserPersonelislemleri userPersonelislemleri = FormFactory.CreateUserPersonelislemleri();
            panel.Controls.Add(userPersonelislemleri);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Kullanici Personel = dataGridView1.SelectedRows[0].DataBoundItem as Kullanici;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();
            UserPersonelBilgi userPersonelBilgi = FormFactory.CreatUserPersonelBilgisi();
            userPersonelBilgi.PersonelBilgi = Personel;
            panel.Controls.Add(userPersonelBilgi);
        }
    }
}
