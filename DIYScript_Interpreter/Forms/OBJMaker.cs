using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static DIYScript_Interpreter.Document;
using static DIYScript_Interpreter.OBJAddingStatus;

namespace DIYScript_Interpreter {
    public partial class OBJMaker : Form {

        private bool isHaveBG = true;

        public OBJMaker() {
            InitializeComponent();
            checkBoxAllowOverlap.Enabled = false;// Just for noob :(
            radioButtonPoint.Checked = true;
        }

        public void setStartMode(bool rBP, bool rbA, bool cBA) {
            radioButtonPoint.Checked = rBP;
            radioButtonArea.Checked = rbA;
            checkBoxAllowOverlap.Checked = cBA;
        }

        public StartMode getStartMode() {
            StartMode mode = StartMode.AreaAnywhere;
            if(radioButtonPoint.Checked) {
                mode = StartMode.Point;
            } else if(radioButtonArea.Checked) {
                if(!checkBoxAllowOverlap.Checked) {
                    mode = StartMode.AreaAnywhere;
                } else {
                    mode = StartMode.AreaNotOverlap;
                }
            } else if(OBJChoose.isAttach) {
                mode = StartMode.Attach;
            }
            return mode;
        }

        public void setOBJtoEdit(OBJ obj) {
            textBoxOBJName.Text = obj.Name;
            MouseState[0] = obj.StrtX[0];
            MouseState[1] = obj.StrtX[1];
            MouseState[2] = obj.StrtY[0];
            MouseState[3] = obj.StrtY[1];
            if(obj.startMode == StartMode.Point) {
                radioButtonPoint.Checked = true;
                radioButtonArea.Checked = false;
            }
            if(obj.startMode == StartMode.AreaAnywhere) {
                radioButtonPoint.Checked = false;
                radioButtonArea.Checked = true;
                checkBoxAllowOverlap.Checked = true;
            }
            if(obj.startMode == StartMode.AreaNotOverlap) {
                radioButtonPoint.Checked = false;
                radioButtonArea.Checked = true;
                checkBoxAllowOverlap.Checked = false;
            }
            if(obj.startMode == StartMode.Attach) {
                radioButtonPoint.Checked = false;
                radioButtonArea.Checked = false;
            }
        }
        private void EditOBJ(StartMode startMode) {
            OBJTemp.Name = textBoxOBJName.Text;
            OBJTemp.startMode = startMode;
            OBJTemp.StrtX = new short[] { (short)MouseState[0], (short)MouseState[1] };
            OBJTemp.StrtY = new short[] { (short)MouseState[2], (short)MouseState[3] };
            OBJTemp.ID = CurrentOBJID;
        }

        private void OBJMaker_Load(object sender, EventArgs e) {
            listViewART.View = Properties.Settings.Default.LViewValue;
            Bitmap b = new Bitmap(640, 480);
            Graphics g = Graphics.FromImage(b);
            try {
                BG NormalBG = Current.BGList.Find(bg => bg.isNormal == true);
                g.DrawImage(NormalBG.bitmap, new Point(0, 0));
            } catch(Exception ex) {
                isHaveBG = false;
                MessageBox.Show("默认背景未被设置。\r" + ex.ToString(), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            canvas.Image = b;
        }

        private void OK_Click(object sender, EventArgs e) {
            if(textBoxOBJName.Text == "") {
                errorProvider.SetError(textBoxOBJName, "未输入名字。");

            } else {
                StartMode StartMode = getStartMode();
                if(!isEdit) {
                    // new a obj
                    OBJTemp = new OBJ();
                    EditOBJ(StartMode);
                    Current.OBJList.Add(OBJTemp);
                } else {
                    // edit a obj
                }


            }

            Close();
        }



        private void radioButtonArea_CheckedChanged(object sender, EventArgs e) {
            checkBoxAllowOverlap.Enabled = radioButtonArea.Checked;
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form OBJChooseForm = new OBJChooser();
            OBJChooseForm.Show();
        }


        private void buttonNewART_Click(object sender, EventArgs e) {
            Animater animator = new Animater();
            animator.Show();
        }

        private void listViewART_SelectedIndexChanged(object sender, EventArgs e) {

        }


        private void textBoxOBJName_TextChanged(object sender, EventArgs e) {
            errorProvider.SetError(textBoxOBJName, null);
        }
        #region ==Mouse Process&Canvas Redraw==
        private void canvas_MouseDown(object sender, MouseEventArgs e) {

            MouseState[0] = e.X;
            MouseState[1] = e.Y;
            MouseState[4] = 1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e) {

            reDraw(MouseState[0], MouseState[1], MouseState[2], MouseState[3], radioButtonArea.Checked && !radioButtonPoint.Checked);
            if(MouseState[4] == 1) {

                MouseState[2] = e.X;
                MouseState[3] = e.Y;
            }

            if(Math.Abs(MouseState[2] - MouseState[0]) > 8 | Math.Abs(MouseState[3] - MouseState[1]) > 8) {

                if(MouseState[2] - MouseState[0] > 15) {
                    direction = Directions.e;
                    if(MouseState[3] - MouseState[1] > 15) {
                        direction = Directions.se;
                    } else if(MouseState[3] - MouseState[1] < -15) {
                        direction = Directions.ne;
                    }
                } else if(MouseState[2] - MouseState[0] < -15) {
                    direction = Directions.w;
                    if(MouseState[3] - MouseState[1] > 15) {
                        direction = Directions.sw;
                    } else if(MouseState[3] - MouseState[1] < -15) {
                        direction = Directions.nw;
                    }
                } else {
                    if(MouseState[3] - MouseState[1] > 5) {
                        direction = Directions.s;
                    } else if(MouseState[3] - MouseState[1] < -5) {
                        direction = Directions.n;
                    }
                }
            }
        }//yeek!

        private void canvas_MouseUp(object sender, MouseEventArgs e) {
            MouseState[2] = e.X;
            MouseState[3] = e.Y;
            MouseState[4] = 0;

        }

        private void reDraw(int x1, int y1, int x2, int y2, bool isArea) {
            Bitmap b = new Bitmap(640, 480);
            Point p1 = new Point(x1, y1);
            Graphics g = Graphics.FromImage(b);

            if(isHaveBG) {

                BG NormalBG = Current.BGList.Find(bg => bg.isNormal == true);
                g.DrawImage(NormalBG.bitmap, new Point(0, 0));
            }

            Pen p = new Pen(Color.Red, 2);
            Point pt = new Point(x2, y2);
            if(isArea) {
                p.DashStyle = DashStyle.Dash;
                g.DrawLine(p, x1, y1, x2, y1);
                g.DrawLine(p, x1, y1, x1, y2);
                g.DrawLine(p, x2, y1, x2, y2);
                g.DrawLine(p, x1, y2, x2, y2);
            } else if(!isArea) {
                p.DashStyle = DashStyle.Solid;
                p.LineJoin = LineJoin.Round;
                g.DrawRectangle(p, x2 - 15, y2 - 15, 30, 30);
            }
            // i dont really trust these radiobuttons
            canvas.Image = b;
        }
        #endregion
        private void buttonNormalART_Click(object sender, EventArgs e) {
            foreach(OBJArt art in OBJTemp.ArtList) {
                art.isNormal = false;
            }

            Current.BGList[listViewART.FocusedItem.Index].isNormal = true;
            buttonNormalART.Enabled = false;
        }

        private void buttonRefreshART_Click(object sender, EventArgs e) {
            listViewART.Clear();
            imageList.Images.Clear();
            imageList.Images.Clear();
            foreach(OBJArt art in OBJTemp.ArtList) {
                foreach(Image i in art.i.Images) {
                    imageList.Images.Add(i);
                }
                listViewART.Items.Add(art.Name, OBJTemp.ArtList.IndexOf(art));

            }
        }
    }
}
