using Kafe.DataAccsess.Abstact;
using Kafe.DataAccsess.Concrete.Entity_Framework.Respository;
using kafe.WinUI;
using Kafe.Bussinuss.Abstract;
using Kafe.Bussinuss.Concrete;
using Kafe.Model.Entity;
using Microsoft.Extensions.DependencyInjection;
using kafe.Personel;
using kafe.WinUI.Personel;
using kafe.Urunler;
using kafe.WinUI.Masalar;
using kafe.WinUI.Urunler;

namespace kafe
{
    internal static class Program
    {
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<frmgiris>();
            services.AddTransient<frmAdminMain>();
            services.AddTransient<frmPersonelMain>();
            services.AddTransient<UserPersoneller>();
            services.AddTransient<UserPersonelislemleri>();
            services.AddTransient<UserMasalar>();
            services.AddTransient<UserMasaIslemleri>();
            services.AddTransient<UserUrunIslemleri>();
            services.AddTransient<UserUrunler>();
            services.AddTransient<UserPersonelBilgi>();
            services.AddTransient<UserMasaBilgi>();
            services.AddTransient<UserUrunBilgileri>();

//*****************************************************************************************************************

            services.AddSingleton<IKullaniciBs, KullaniciBs>();
            services.AddSingleton<IKullaniciRepository, EfKullaniciRepository>();

            services.AddSingleton<IMasaBs,MasaBs>();
            services.AddSingleton<IMasaRepository,EfMasaRepository>();

            services.AddSingleton<IUrunBs,UrunBs>();
            services.AddSingleton<IUrunRepository, EfUrunRepository>();

            services.AddSingleton<IAdisyonBs,AdisyonBs>();
            services.AddSingleton<IAdisyonRepository, EfAdisyonRepository>();

            services.AddSingleton<IBelirlemeBs,BelirlemeBs>();
            services.AddSingleton<IBelirlemeRepository,EfBelirlemeRepository>();

            services.AddSingleton<IKategoriBs,KategoriBs>();
            services.AddSingleton<IKategoriRepository, EfKategoriRepository>();


            
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            FormFactory.SetServicesProvider(services.BuildServiceProvider());
            Application.Run(FormFactory.CreatefrmGiris());
        }
    }
}