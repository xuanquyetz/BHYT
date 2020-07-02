using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;

namespace BHYT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("The Asphalt World");
            //SplashScreenManager.ShowForm(typeof(SplashScreen1));
            Application.Run(new FormMain());
           // Application.Run(new FormThemThongTinKhachHang());
        }
    }
}
