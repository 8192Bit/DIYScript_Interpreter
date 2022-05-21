using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static DIYScript_Interpreter.Document;

namespace DIYScript_Interpreter {
    public partial class Importer : Form {

        private static Image i = null;
        private static string FName;
        private static Image itemp = new Bitmap(640, 480);
        private static Graphics g = Graphics.FromImage(itemp);

        public void setFile(string fileName, Image image) {
            FName = fileName;
            i = image;
        }

        public Importer() {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void OK_Click(object sender, EventArgs e) {
            if (textBoxBGName.Text == "") {
                errorProvider.SetError(textBoxBGName, "未输入名字。");
            } else {
                BG bg = new BG();
                bg.Name = textBoxBGName.Text;
                bg.bitmap = (Bitmap)itemp.Clone();
                bg.ID = BGAddingStatus.CurrentBGID;

                Current.BGList.Add(bg);
                if (Current.BGList.Count == 1) {
                    bg.isNormal = true;
                }
                BGAddingStatus.CurrentBGID++;
                Close();
            }

        }
        private void reDraw() {
            g.DrawImage(i, new Rectangle(0, 0, 640, 480));
            canvas.Image = itemp;
        }

        private void Importer_Load(object sender, EventArgs e) {
            textBoxBGName.Text = FName;
            reDraw();
        }

        private void textBoxBGName_TextChanged(object sender, EventArgs e) {
            errorProvider.SetError(textBoxBGName, null);
        }

        private void comboBoxInterpolation_SelectedIndexChanged(object sender, EventArgs e) {
            g.InterpolationMode = (InterpolationMode)comboBoxInterpolation.SelectedIndex;
            reDraw();
        }
    }
}
