using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
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
                    bg.bitmap = BGAddingStatus.temp;
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
        private void reDraw() {
            BGAddingStatus.gt.DrawImage(BGAddingStatus.bitmap, new Rectangle(0, 0, 640, 480));
            pictureBox1.Image = BGAddingStatus.temp;
        }
        private void BGMaker_Load(object sender, EventArgs e) {
            reDraw();
        }

        private void textBoxBGName_TextChanged(object sender, EventArgs e) {
            errorProvider.SetError(textBoxBGName, null);
        }

        private void trackBarSmooth_Scroll(object sender, EventArgs e) {
            switch (this.trackBarSmooth.Value) {
                case 0:
                    BGAddingStatus.gt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    break;
                case 1:
                    BGAddingStatus.gt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                    break;
                case 2:
                    BGAddingStatus.gt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                    break;
                case 3:
                    BGAddingStatus.gt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    break;
                case 4:
                    BGAddingStatus.gt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    break;
            }
            reDraw();
        }

        private void comboBoxInterpolation_SelectedIndexChanged(object sender, EventArgs e) {
            BGAddingStatus.gt.InterpolationMode = (InterpolationMode)comboBoxInterpolation.SelectedIndex;
            reDraw();
        }
    }
}
