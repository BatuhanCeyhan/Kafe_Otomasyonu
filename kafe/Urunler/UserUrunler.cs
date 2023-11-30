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

namespace kafe.Urunler
{
    public partial class UserUrunler : UserControl
    {
        IUrunBs UrunBs;
        public UserUrunler(IUrunBs _urunBs)
        {
            this.Load += UserUrunler_Load;
            UrunBs = _urunBs;
            InitializeComponent();
        }



        private void UserUrunler_Load(object sender, EventArgs e)
        {
            Vericekme();
        }

        public void Vericekme()
        {
            dataGridView1.DataSource = UrunBs.GetAll();
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
                    Vericekme();

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

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun urun = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();
            UserUrunBilgileri userUrunBilgileri = FormFactory.CreateUserUrunBilgileri();
            userUrunBilgileri.Urun = urun;
            panel.Controls.Add(userUrunBilgileri);
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
