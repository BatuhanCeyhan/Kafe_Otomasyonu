using kafe.Personel;
using kafe.Urunler;
using kafe.WinUI.Masalar;
using kafe.WinUI.Personel;
using kafe.WinUI.Urunler;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafe.WinUI
{
    public class FormFactory
    {
        private static IServiceProvider serviceProvider;
        public static void SetServicesProvider(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }
        public static frmgiris CreatefrmGiris()
        {
            return serviceProvider.GetRequiredService<frmgiris>();
        }
        public static frmAdminMain CreatefrmAdminMain()
        {
            return serviceProvider.GetRequiredService<frmAdminMain>();
        }
        public static frmPersonelMain CreatefrmPersonelMain()
        {
            return serviceProvider.GetRequiredService<frmPersonelMain>();
        }
        public static UserPersoneller CreateUserPersoneller()
        {
            return serviceProvider.GetRequiredService<UserPersoneller>();
        }
        public static UserPersonelislemleri CreateUserPersonelislemleri()
        {
            return serviceProvider.GetRequiredService<UserPersonelislemleri>();
        }
        public static UserMasalar CreateUserMasalar()
        {
            return serviceProvider.GetRequiredService<UserMasalar>();
        }
        public static UserMasaIslemleri CreateUserMasaIslemleri()
        {
            return serviceProvider.GetRequiredService<UserMasaIslemleri>();
        }
        public static UserUrunler CreateUserUrunler()
        {
            return serviceProvider.GetRequiredService<UserUrunler>();

        }
        public static UserUrunIslemleri CreateUserUrunislemleri()
        {
            return serviceProvider.GetRequiredService<UserUrunIslemleri>();
        }
        public static UserMasaBilgi CreateUserMasaBilgi()
        {
            return serviceProvider.GetRequiredService<UserMasaBilgi>();
        }           
        
        public static UserPersonelBilgi CreatUserPersonelBilgisi()
        {
            return serviceProvider.GetRequiredService<UserPersonelBilgi>();
        }
        public static UserUrunBilgileri CreateUserUrunBilgileri()
        {
            return serviceProvider.GetRequiredService<UserUrunBilgileri>();
        }



    }
}
