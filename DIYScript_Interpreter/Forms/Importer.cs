using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static DIYScript_Interpreter.Document;

namespace DIYScript_Interpreter {
    public partial class Importer : Form {

        private bool isBG;

        public Importer() {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void OK_Click(object sender, EventArgs e) {
            if(textBoxBGName.Text == "") {
                errorProvider.SetError(textBoxBGName, "未输入名字。");
            } else {

                try {
                    BG bg = new BG();
                    bg.Name = textBoxBGName.Text;
                    bg.bitmap = BGAddingStatus.temp;
                    BGAddingStatus.CurrentBGID++;
                    bg.ID = BGAddingStatus.CurrentBGID;
                    Current.BGList.Add(bg);
                    if(Current.BGList.Count == 1) {
                        bg.isNormal = true;
                    }
                } catch {
                }
                Close();
            }

        }
        private void reDraw() {
            BGAddingStatus.gt.DrawImage(BGAddingStatus.bitmap, new Rectangle(0, 0, 640, 480));
            canvas.Image = BGAddingStatus.temp;
        }
        private void Importer_Load(object sender, EventArgs e) {
            reDraw();
        }

        private void textBoxBGName_TextChanged(object sender, EventArgs e) {
            errorProvider.SetError(textBoxBGName, null);
        }



        private void comboBoxInterpolation_SelectedIndexChanged(object sender, EventArgs e) {
            BGAddingStatus.gt.InterpolationMode = (InterpolationMode)comboBoxInterpolation.SelectedIndex;
            reDraw();
        }
    }
}
