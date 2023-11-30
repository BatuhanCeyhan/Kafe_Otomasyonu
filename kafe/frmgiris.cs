using kafe.WinUI;
using Kafe.Bussinuss.Abstract;
using Kafe.Model.Entity;

namespace kafe
{
    public partial class frmgiris : Form
    {
        IKullaniciBs KullaniciBs;


        public frmgiris(IKullaniciBs _kullaniciBs)
        {
            KullaniciBs = _kullaniciBs;
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;


            Kullanici Admin = KullaniciBs.Get(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre && x.BelirlemeID == 1);
            Kullanici Personel = KullaniciBs.Get(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre && x.BelirlemeID == 2);



            if (Admin != null)
            {
                frmAdminMain frmAdminMain = FormFactory.CreatefrmAdminMain();
                frmAdminMain.Show();
                this.Hide();

            }
            else if (Personel != null)
            {
                frmPersonelMain frmPersonelMain = FormFactory.CreatefrmPersonelMain();
                frmPersonelMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Bulunamadý");
            }


        }
    }
}