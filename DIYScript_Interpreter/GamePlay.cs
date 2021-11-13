using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static DIYScript_Interpreter.GamePlay.InterpreterState;

namespace DIYScript_Interpreter {
    public partial class GamePlay : Form {

        public static class InterpreterState {
            public static Bitmap FrameBuffer = new Bitmap(640, 480);
            public static Int64 Ticked = 0;
            public static Int64 Rendered = 0;
            public static Graphics render = Graphics.FromImage(FrameBuffer);
            public static int[] MouseState = { 0, 0, 0, 0, 0 }; //{StartX,StartY,EndX,EndY,isDown}
        }
        public GamePlay() {
            InitializeComponent();
            InterpreterState.render.Clear(Color.AliceBlue);
        }

        private void GamePlay_Load(object sender, EventArgs e) {
            foreach (OBJ initOBJ in GAME.Current.OBJList) {

            }
        }

        private void ticker_Tick(object sender, EventArgs e) {

            InterpreterState.render.Clear(Color.White);
            InterpreterState.Ticked++;
            //Main Interpreter cycle
            //InterpreterState.FrameBuffer
            labelTicked.Text = "Tick数:    " + InterpreterState.Ticked;
            Pen p = new Pen(Color.Blue, 2);//定义了一个蓝色,宽度为的画笔
            Point p1 = new Point(100 * (int)Math.Sin(Ticked) + 1, 800 * (int)Math.Cos(Ticked) + 1);
            Point p2 = new Point(100 * (int)Math.Sin(Ticked), 80 * (int)Math.Cos(Ticked));
            render.DrawString("MakerMatic 42 Interpreter Demo", new Font("微软雅黑", 24), new LinearGradientBrush(p1, p2, Color.Azure, Color.PaleGreen), 10, 10);
            VRamCopy();




        }

        private void VRamCopy() {
            Rendered++;
            labelRenderedFrame.Text = "已渲染帧数:" + Rendered;
            canvas.Image = InterpreterState.FrameBuffer;
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
            switch (this.trackBarSmooth.Value) {
                case 0:
                    InterpreterState.render.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    break;
                case 1:
                    InterpreterState.render.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                    break;
                case 2:
                    InterpreterState.render.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                    break;
                case 3:
                    InterpreterState.render.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    break;
                case 4:
                    InterpreterState.render.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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
            if (MouseState[4] == 1) {

                MouseState[2] = e.X;
                MouseState[3] = e.Y;
            }

            if (Math.Abs(MouseState[2] - MouseState[0]) > 8 | Math.Abs(MouseState[3] - MouseState[1]) > 8) {

                labelMouse.Text = "鼠标拖动" + MouseState[0] + " " + MouseState[1] + " " + MouseState[2] + " " + MouseState[3];
                labelDirection.ForeColor = Color.Magenta;
                if (MouseState[2] - MouseState[0] > 15) {
                    labelDirection.Text = "→";
                    if (MouseState[3] - MouseState[1] > 15) {
                        labelDirection.Text = "↘";
                    } else if (MouseState[3] - MouseState[1] < -15) {
                        labelDirection.Text = "↗";
                    }
                } else if (MouseState[2] - MouseState[0] < -15) {
                    labelDirection.Text = "←";
                    if (MouseState[3] - MouseState[1] > 15) {
                        labelDirection.Text = "↙";
                    } else if (MouseState[3] - MouseState[1] < -15) {
                        labelDirection.Text = "↖";
                    }
                } else {
                    if (MouseState[3] - MouseState[1] > 5) {
                        labelDirection.Text = "↓";
                    } else if (MouseState[3] - MouseState[1] < -5) {
                        labelDirection.Text = "↑";
                    }
                }
            }
        }//yeek!

        private void canvas_MouseUp(object sender, MouseEventArgs e) {
            MouseState[2] = e.X;
            MouseState[3] = e.Y;
            MouseState[4] = 0;

            labelMouse.Text = "鼠标状态" + MouseState[0] + " " + MouseState[1] + " " + MouseState[2] + " " + MouseState[3];
            labelDirection.ForeColor = Color.LimeGreen;
        }


    }
}
