using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    public partial class Options : Form {

        public Options() {
            InitializeComponent();
        }

        private void buttonFont_Click(object sender, EventArgs e) {
        }

        private void Options_Load(object sender, EventArgs e) {

            Properties.Settings.Default.LViewValue = (View)comboBox1.SelectedIndex;
            Properties.Settings.Default.LViewValue = listViewExample.View;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            listViewExample.View = (View)comboBox1.SelectedIndex;
            button2.Enabled = true;
        }








        private void button2_Click(object sender, EventArgs e) {

            Properties.Settings.Default.LViewValue = listViewExample.View;
            Properties.Settings.Default.Save();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            button2.PerformClick();
            Close();
        }

        private void listViewExample_SelectedIndexChanged(object sender, EventArgs e) {
            MessageBox.Show(":)");
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
