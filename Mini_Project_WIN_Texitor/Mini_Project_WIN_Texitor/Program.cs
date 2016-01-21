using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Texitor
{
    static class Program
    {
        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SHChangeNotify(uint wEventId , uint uFlags , IntPtr dwItem1,IntPtr dwItem2);
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (!IsAssociated())
            {
            }
            else
            {
                Associate();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
                Application.Run(new Form1());
            else
                Application.Run(new Form1(args[0]));
        }

        public static bool IsAssociated()
        {
            return (Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.rtf", false) == null);
        }
        public static void Associate()
        {
            //Association of File Types in Windows with Registry Key Creations.
            RegistryKey TypeReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\.rtf");
            RegistryKey AppReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\Texitor.exe");
            RegistryKey AppTypeAssoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.rtf");
            TypeReg.CreateSubKey("DefaultIcon").SetValue("","C:\\PandoraText.ico");
            TypeReg.CreateSubKey("PerceivedType").SetValue("", "Text");

            AppReg.CreateSubKey("shell\\open\\command").SetValue("","\""+Application.ExecutablePath+"\" %1");
            AppReg.CreateSubKey("shell\\edit\\command").SetValue("", "\"" + Application.ExecutablePath + "\" %1");
            AppReg.CreateSubKey("DefaultIcon").SetValue("", "C:\\PandoraText.ico");

            AppTypeAssoc.CreateSubKey("UserChoice").SetValue("Progid", "Applications\\Texitor.exe");
            SHChangeNotify(0x08000000 , 0x0000 , IntPtr.Zero , IntPtr.Zero);

        }
    }
}
