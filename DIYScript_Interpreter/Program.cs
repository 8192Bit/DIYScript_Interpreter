using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {

    static class Program {
        [STAThread]

        public static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
