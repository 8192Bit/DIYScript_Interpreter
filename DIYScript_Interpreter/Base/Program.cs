using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    internal static class Program {

        public static MainForm m;

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m = new MainForm();
            Application.Run(m);
        }
    }
}
