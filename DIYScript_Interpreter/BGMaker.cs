using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static DIYScript_Interpreter.GAME;

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
                    BG bg = new BG();
                    bg.Name = textBoxBGName.Text;
                    bg.bitmap = BGAddingStatus.bitmap;
                    BGAddingStatus.CurrentBGID++;
                    bg.ID = BGAddingStatus.CurrentBGID;
                    GAME.Current.BGList.Add(bg);
                    if (Current.BGList.Count == 1) {
                        bg.isNormal = true;
                    }
                } catch {
                }
                Close();
            }

        }

        private void BGMaker_Load(object sender, EventArgs e) {
            Bitmap b = BGAddingStatus.bitmap;
            Graphics g = Graphics.FromImage(b);
            pictureBox1.Image = BGAddingStatus.bitmap;
        }

        private void textBoxBGName_TextChanged(object sender, EventArgs e) {
            errorProvider.SetError(textBoxBGName, null);
        }

        private void trackBarSmooth_Scroll(object sender, EventArgs e) {
            switch (this.trackBarSmooth.Value) {
                case 0:
                    BGAddingStatus.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    break;
                case 1:
                    BGAddingStatus.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                    break;
                case 2:
                    BGAddingStatus.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                    break;
                case 3:
                    BGAddingStatus.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    break;
                case 4:
                    BGAddingStatus.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    break;
            }
        }
    }
}
