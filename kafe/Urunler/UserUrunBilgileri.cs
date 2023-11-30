using kafe.Urunler;
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

namespace kafe.WinUI.Urunler
{
    public partial class UserUrunBilgileri : UserControl
    {
        public Urun Urun { get; set; }
        IUrunBs urunbs;
        
        public UserUrunBilgileri(IUrunBs _urunbs)
        {
            this.Load += UserUrunBilgileri_Load;
            urunbs = _urunbs;
            InitializeComponent();
            //this.urunBoyutuBs = urunBoyutuBs;
        }

        private void UserUrunBilgileri_Load(object sender, EventArgs e)
        {
            if (Urun != null)
            {
                switch (Urun.KategoriID)
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

                cmbUrunBoyutu.Text = Urun.UrunBoyutu;
                txtUrunAdi.Text = Urun.UrunAdi;
                txtUcret.Text = Urun.Ucreti.ToString();
                txtNasilYapilir.Text = Urun.NasilYapilir.ToString();
                pbFotograf.ImageLocation = Application.StartupPath + Urun.Resim;
                VerileriCekme();

            }
            VerileriCekme();
        }
        public void VerileriCekme()
        {
            dataGridView1.DataSource = urunbs.GetAll();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun Urun1 = dataGridView1.SelectedRows[0].DataBoundItem as Urun;

            if (Urun1 != null)
            {

                DialogResult dr = MessageBox.Show($"{Urun1.UrunAdi}  Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Urun SilinecekUrun = urunbs.Get(x => x.ID == Urun1.ID);
                    urunbs.Delete(SilinecekUrun);
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
            Urun Urun1 = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();

            userUrunIslemleri.Urun1 = Urun1;
            panel.Controls.Add(userUrunIslemleri);

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();

            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();
            panel.Controls.Add(userUrunIslemleri);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Urun urun = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();
            UserUrunBilgileri userUrunBilgileri = FormFactory.CreateUserUrunBilgileri();
            userUrunBilgileri.Urun = urun;
            panel.Controls.Add(userUrunBilgileri);
        }
    }
}
