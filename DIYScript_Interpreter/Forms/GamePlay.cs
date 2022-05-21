using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static DIYScript_Interpreter.Document;
using static DIYScript_Interpreter.GamePlay.InterpreterState;

namespace DIYScript_Interpreter {

    public partial class GamePlay : Form {

        public GamePlay() {
            InitializeComponent();
        }
        public static class InterpreterState {
            public static bool isHaveBG = Current.BGList.Count == 0 ? false : true;
            public static System.Drawing.Image currentBG = Current.BGList.Count == 0 ? null : Current.BGList.Find(x => x.isNormal == true).bitmap;
            public static System.Drawing.Bitmap FrameBuffer = new System.Drawing.Bitmap(640, 480);
            public static long Ticked = 0;
            public static long Rendered = 0;
            public static int[] MouseState = { 0, 0, 0, 0, 0 }; //{StartX,StartY,EndX,EndY,isDown}
            public static Directions direction;
        }
        private void InitializeGraphics() {
            int w = this.Width;
            int h = this.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -1, 1);
            GL.Viewport(0, 0, w, h);
        }

        private void GamePlay_Load(object sender, EventArgs e) {
            //Start();
        }

        private byte[] getImgByte(Image image) {
            MemoryStream ms = new MemoryStream();
            try {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] b = ms.GetBuffer();
                return b;
            } catch (Exception ex) {
                throw ex;
            } finally {
                ms.Close();
            }

        }

        private void ticker_Tick(object sender, EventArgs e) {
            glCanvas.MakeCurrent();
            InitializeGraphics();

            GL.ClearColor(Color.Aquamarine);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            if (isHaveBG) {
                GL.Bitmap(640, 480, 1, 1, 0, 0, getImgByte(currentBG));
            }

            // 这里画笔为黑色，LineLoop画出图形的边框
            GL.Color3(System.Drawing.Color.Black);
            // 第一个图形（圆）

            GL.Begin(BeginMode.LineLoop);
            double Pi = 3.1415926536f;
            float R = 100f;
            //n表示用多边形绘制圆的精度，可以考虑增大精度
            int n = 40;
            for (int i = 0; i < n; i++) {
                GL.Vertex2(200 + R * Math.Cos(2 * Pi * i / n), 200 + R * Math.Sin(2 * Pi * i / n));
            }

            GL.End();
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex2(300, 100);
            GL.Vertex2(300, 50);
            GL.Vertex2(400, 50);
            GL.Vertex2(400, 100);
            GL.End();

            glCanvas.SwapBuffers();

            Ticked++;
            labelTicked.Text = "Tick数:    " + Ticked;
            if (listBoxOBJ.SelectedIndex > 0 && listBoxOBJ.SelectedIndex < listBoxOBJ.Items.Count) {
                try {
                    OBJ tempOBJ = Current.OBJList[listBoxOBJ.SelectedIndex];
                    listView.Items[0].SubItems[1].Text = Convert.ToString(tempOBJ.PosX);
                    listView.Items[1].SubItems[1].Text = Convert.ToString(tempOBJ.PosY);
                    listView.Items[2].SubItems[1].Text = Convert.ToString(tempOBJ.Switch);
                    listView.Items[3].SubItems[1].Text = Convert.ToString(tempOBJ.Rotation);
                    listView.Items[4].SubItems[1].Text = Convert.ToString(tempOBJ.Scale);
                } finally { }
            }


            VRamCopy();




        }

        private void VRamCopy() {
            Rendered++;
            labelRenderedFrame.Text = "已渲染帧数:" + Rendered;

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
            switch (trackBarSmooth.Value) {
                case 0:
                    //render.SmoothingMode = SmoothingMode.None;
                    break;
                case 1:
                    //render.SmoothingMode = SmoothingMode.HighSpeed;
                    break;
                case 2:
                    //render.SmoothingMode = SmoothingMode.Default;
                    break;
                case 3:
                    //render.SmoothingMode = SmoothingMode.HighQuality;
                    break;
                case 4:
                    //render.SmoothingMode = SmoothingMode.AntiAlias;
                    break;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            ticker.Stop();
            Ticked = 0;
            //render.Clear(Color.White);
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
