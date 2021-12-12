using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {

    static class Program {
        public static MainForm m = new MainForm();

        [STAThread]
        public static void Main() {
            if (DIYScript_Interpreter.Properties.Settings.Default.isAero) {

                Application.EnableVisualStyles();
            }
            Application.Run(m);
            //Application.SetCompatibleTextRenderingDefault(true);
        }
    }
}
