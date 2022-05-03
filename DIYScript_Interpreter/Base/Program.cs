using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    internal static class Program {
        public static MainForm m = new MainForm();

        [STAThread]
        public static void Main() {
            //Application.SetCompatibleTextRenderingDefault(true);

            Application.EnableVisualStyles();
            Application.Run(m);
        }
    }
}
