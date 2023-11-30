using kafe.WinUI;
using kafe.WinUI.Personel;
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

namespace kafe.Personel
{
    public partial class UserPersoneller : UserControl
    {
        IKullaniciBs KullaniciBs;

        public UserPersoneller(IKullaniciBs _KullaniciBs)
        {
            this.Load += UserPersoneller_Load;
            KullaniciBs = _KullaniciBs;
            InitializeComponent();

        }


        public void VerileriCekme()
        {
            dataGridView1.DataSource = KullaniciBs.GetAll();
        }
        private void UserPersoneller_Load(object sender, EventArgs e)
        {
            VerileriCekme();
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





        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();

            UserPersonelislemleri userPersonelislemleri = FormFactory.CreateUserPersonelislemleri();
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
            UserPersonelBilgi userPersonelBilgi = FormFactory.CreatUserPersonelBilgisi();
            userPersonelBilgi.PersonelBilgi = Personel;
            panel.Controls.Add(userPersonelBilgi);
        }
    }
}
