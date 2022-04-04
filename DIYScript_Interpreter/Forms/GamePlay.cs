using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static DIYScript_Interpreter.Document;
using static DIYScript_Interpreter.GamePlay.InterpreterState;

namespace DIYScript_Interpreter {

    public partial class GamePlay : Form {
        public static class InterpreterState {

            public static Bitmap FrameBuffer = new Bitmap(640, 480);
            public static long Ticked = 0;
            public static long Rendered = 0;
            public static Graphics render = Graphics.FromImage(FrameBuffer);
            public static int[] MouseState = { 0, 0, 0, 0, 0 }; //{StartX,StartY,EndX,EndY,isDown}
            public static Directions direction;
        }
        public GamePlay() {
            InitializeComponent();
            render.Clear(Color.AliceBlue);
        }

        private void GamePlay_Load(object sender, EventArgs e) {
            foreach(OBJ initOBJ in Current.OBJList) {
                listBoxOBJ.Items.Add(initOBJ.Name);

                switch(initOBJ.StartMode) {
                    // 1 == Location, Point
                    // 2 == Location, Area, Anywhere
                    // 3 == Location, Area, Try not to overlap
                    // 4 == Attath to OBJ

                    // If StartMode == 1, StrtX[] = {x1, x2}, StrtY[] = {y1, y2}
                    // If StartMode == 2 or 3, StrtX[] = {x, null}, StrtY[] = {y, null}
                    // If StartMode == 4, StrtX[] = {offsetx, null}, StrtY[]={offsety, null}
                }
            }
        }

        private void ticker_Tick(object sender, EventArgs e) {

            render.Clear(Color.White);
            Ticked++;
            //Main Interpreter cycle
            //InterpreterState.FrameBuffer
            labelTicked.Text = "Tick数:    " + Ticked;
            Pen p = new Pen(Color.Blue, 2);//定义了一个蓝色,宽度为的画笔
            Point p1 = new Point(10 * (int)Math.Sin(Ticked) + 1, 80 * (int)Math.Cos(Ticked) - 4);
            Point p2 = new Point(100 * (int)Math.Sin(Ticked), 80 * (int)Math.Sin(Ticked));

            try {
                OBJ tempOBJ = Current.OBJList[listBoxOBJ.SelectedIndex];
                listView.Items[0].SubItems[1].Text = Convert.ToString(tempOBJ.PosX);
                listView.Items[1].SubItems[1].Text = Convert.ToString(tempOBJ.PosY);
                listView.Items[2].SubItems[1].Text = Convert.ToString(tempOBJ.Switch);
                listView.Items[3].SubItems[1].Text = Convert.ToString(tempOBJ.Rotation);
                listView.Items[4].SubItems[1].Text = Convert.ToString(tempOBJ.Scale);
            } finally { }

            if(Ticked < 200) {

                render.DrawString("MakerMatic 42 Interpreter Demo", new Font("微软雅黑", Ticked), new LinearGradientBrush(p1, p2, Color.Brown, Color.PaleGreen), 10, 10);
            }
            if(Ticked > 200&&Ticked <500) {
                render.TranslateTransform(5, 5);
            }
            if(Ticked > 200 && Ticked < 500) {
                render.DrawRectangle(p, 50, 50, Ticked, Ticked);
                render.RotateTransform(Ticked,MatrixOrder.Prepend);
                render.DrawEllipse(p, -50, -50, Ticked, Ticked);
            }
            
            if(Ticked > 500 && Ticked < 800) {
                for(int j=0; j < 300; j++) {
                    render.DrawLine(p, j/10, (int)(Math.Sin(j)*100+50),j/10+2, (int)(Math.Sin(j)*100)+50);
                    

                }
            }
            render.DrawLine(p, p1, p2);
            VRamCopy();




        }

        private void VRamCopy() {
            Rendered++;
            labelRenderedFrame.Text = "已渲染帧数:" + Rendered;
            canvas.Image = FrameBuffer;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e) {
            labelSpeed.Text = "时间速度: " + trackBarSpeed.Value;
            ticker.Interval = trackBarSpeed.Value;
        }

        private void buttonTickStrat_Click(object sender, EventArgs e) {

            ticker.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e) {
            ticker.Stop();
        }



        private void GamePlay_Paint(object sender, PaintEventArgs e) {

        }

        private void trackBarSmooth_Scroll(object sender, EventArgs e) {
            switch(trackBarSmooth.Value) {
                case 0:
                    render.SmoothingMode = SmoothingMode.None;
                    break;
                case 1:
                    render.SmoothingMode = SmoothingMode.HighSpeed;
                    break;
                case 2:
                    render.SmoothingMode = SmoothingMode.Default;
                    break;
                case 3:
                    render.SmoothingMode = SmoothingMode.HighQuality;
                    break;
                case 4:
                    render.SmoothingMode = SmoothingMode.AntiAlias;
                    break;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            ticker.Stop();
            Ticked = 0;
            render.Clear(Color.White);

            InitializeComponent();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e) {

            MouseState[0] = e.X;
            MouseState[1] = e.Y;
            MouseState[4] = 1;
            labelMouse.Text = "鼠标状态" + MouseState[0] + " " + MouseState[1] + " " + MouseState[2] + " " + MouseState[3];
            labelDirection.ForeColor = Color.Red;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e) {
            if(MouseState[4] == 1) {

                MouseState[2] = e.X;
                MouseState[3] = e.Y;
            }

            if(Math.Abs(MouseState[2] - MouseState[0]) > 8 | Math.Abs(MouseState[3] - MouseState[1]) > 8) {

                labelMouse.Text = "鼠标拖动" + MouseState[0] + " " + MouseState[1] + " " + MouseState[2] + " " + MouseState[3];
                labelDirection.ForeColor = Color.Magenta;
                if(MouseState[2] - MouseState[0] > 15) {
                    labelDirection.Text = "→";
                    if(MouseState[3] - MouseState[1] > 15) {
                        labelDirection.Text = "↘";
                    } else if(MouseState[3] - MouseState[1] < -15) {
                        labelDirection.Text = "↗";
                    }
                } else if(MouseState[2] - MouseState[0] < -15) {
                    labelDirection.Text = "←";
                    if(MouseState[3] - MouseState[1] > 15) {
                        labelDirection.Text = "↙";
                    } else if(MouseState[3] - MouseState[1] < -15) {
                        labelDirection.Text = "↖";
                    }
                } else {
                    if(MouseState[3] - MouseState[1] > 5) {
                        labelDirection.Text = "↓";
                    } else if(MouseState[3] - MouseState[1] < -5) {
                        labelDirection.Text = "↑";
                    }
                }
            }
        }//yeek!

        private void canvas_MouseUp(object sender, MouseEventArgs e) {
            MouseState[2] = e.X;
            MouseState[3] = e.Y;
            MouseState[4] = 0;

            labelMouse.Text = "鼠标抬起" + MouseState[0] + " " + MouseState[1] + " " + MouseState[2] + " " + MouseState[3];
            labelDirection.ForeColor = Color.LimeGreen;
        }

        private void GamePlay_FormClosed(object sender, FormClosedEventArgs e) {
            Program.m.Show();
        }

        private void buttonVisualizer_Click(object sender, EventArgs e) {
        }

        private void listBoxOBJ_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
