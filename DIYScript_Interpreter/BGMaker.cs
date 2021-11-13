using System;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    public partial class BGMaker : Form {
        public BGMaker() {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void OK_Click(object sender, EventArgs e) {
            if (textBoxBGName.Text == "") {
                errorProvider.SetError(textBoxBGName, "把名字抄100遍!");
            } else {

                try {
                    GAME.Current.AddBG(BGAddingStatus.bitmap, textBoxBGName.Text);

                } catch (Exception ex) {
                    MessageBox.Show("SystemERR. DEAD-END-CODE = " + ex.GetType());
                    Console.WriteLine();
                }
                Close();
            }

        }

        private void BGMaker_Load(object sender, EventArgs e) {
            pictureBox1.Image = BGAddingStatus.bitmap;
        }

        private void textBoxBGName_TextChanged(object sender, EventArgs e) {
            errorProvider.SetError(textBoxBGName, null);
        }
    }
}
