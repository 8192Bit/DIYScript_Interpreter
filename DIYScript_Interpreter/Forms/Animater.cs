using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    public partial class Animater : Form {
        public bool isFullView;
        public bool isFirstAdd = true;
        public bool isFromFront;

        public Animater() {
            InitializeComponent();
        }

        private void refresh() {
            listViewFrames.Items.Clear();
            int temp = -1;
            foreach(Image i in imageList.Images) {
                temp++;
                listViewFrames.Items.Add(temp.ToString(), temp);
            }
        }

        private void pictureBoxCurrent_DoubleClick(object sender, EventArgs e) {
            if(!isFullView) {
                Height += pictureBoxCurrent.Image.Height - pictureBoxCurrent.Height;
                pictureBoxCurrent.Size = pictureBoxCurrent.Image.Size;
                pictureBoxCurrent.SizeMode = PictureBoxSizeMode.Normal;
                isFullView = true;
            } else {
                pictureBoxCurrent.Size = new Size(100, 100);
                Width = 800;
                Height = 292;
                isFullView = false;
                pictureBoxCurrent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            Refresh();
        }

        private void ButtonAddBefore_Click(object sendor, EventArgs e) {
            openFileDialog.ShowDialog();
            isFromFront = true;
        }

        private void openFileDialog_FileOK(object sendor, CancelEventArgs e) {
            Image i = new Bitmap(openFileDialog.FileName);
            if(isFirstAdd) {
                imageList.ImageSize = i.Size;
                isFirstAdd = false;
            } else if(i.Size != imageList.ImageSize) {
                MessageBox.Show("要添加的帧与帧列表中的大小不匹配。" + "\r" + "是否添加？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
            if(isFromFront) {
                Image temp = imageList.Images[imageList.Images.Count - 1];
                imageList.Images[imageList.Images.Count - 1] = i;
                imageList.Images.Add(temp);
            } else {
                imageList.Images.Add(i);
            }
            refresh();
        }

        private void Animater_Load(object sender, EventArgs e) {

        }

        private void buttonAddAfter_Click(object sender, EventArgs e) {

            openFileDialog.ShowDialog();
            isFromFront = false;
        }

        private void 从GIFToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            OBJArt art = new OBJArt();
            art.Name = toolStripTextBoxARTName.Text;
            art.ID = OBJArtAddingStatus.CurrentOBJArtID;
            art.i = imageList;
            OBJArtAddingStatus.CurrentOBJArtID++;
        }

        private void listViewFrames_SelectedIndexChanged(object sender, EventArgs e) {
            labelFrame.Text = listViewFrames.FocusedItem.Index + "/" + (imageList.Images.Count - 1);
            pictureBoxCurrent.Image = imageList.Images[listViewFrames.FocusedItem.Index];
        }

        private void buttonPlay_Click(object sender, EventArgs e) {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e) {
            if(listViewFrames.FocusedItem.Index < imageList.Images.Count - 1) {
                listViewFrames.FocusedItem = listViewFrames.Items[listViewFrames.FocusedItem.Index + 1];
            } else {
                listViewFrames.FocusedItem = listViewFrames.Items[0];
            }
            labelFrame.Text = listViewFrames.FocusedItem.Index + "/" + (imageList.Images.Count - 1);
            pictureBoxCurrent.Image = imageList.Images[listViewFrames.FocusedItem.Index];
        }

        private void trackBarTimeSpeed_Scroll(object sender, EventArgs e) {
            timer.Interval = trackBarTimeSpeed.Value * 100 + 1;
        }

        private void buttonPause_Click(object sender, EventArgs e) {
            timer.Stop();
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            timer.Stop();
            listViewFrames.FocusedItem = listViewFrames.Items[0];
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e) {
            imageList.Images.RemoveAt(listViewFrames.FocusedItem.Index);
            refresh();
        }
    }
}
