
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Picker;
using scanface;

namespace FaceattendanaceNum
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var defaultFont = new Font("Khmer OS Content", 10);
            WindowsFormsSettings.DefaultFont =
                WindowsFormsSettings.DefaultMenuFont = defaultFont;
            ApplicationConfiguration.Initialize();
            Application.Run(new Xtratest());
        }
    }
}