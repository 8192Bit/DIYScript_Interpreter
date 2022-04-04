using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    internal static class Program {
        public static MainForm m = new MainForm();

        [STAThread]
        public static void Main() {

            //Application.EnableVisualStyles();
            if(Properties.Settings.Default.isAero) {

                Application.EnableVisualStyles();
            }
            Application.Run(m);
            //Application.SetCompatibleTextRenderingDefault(true);
        }
    }
}
