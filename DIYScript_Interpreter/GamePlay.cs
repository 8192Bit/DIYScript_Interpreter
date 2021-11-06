using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIYScript_Interpreter.Properties;


namespace DIYScript_Interpreter
{
    public partial class GamePlay : Form
    {
        public static class InterpreterState{
            public static Bitmap FrameBuffer = new Bitmap(640, 480);
            public static Int64 Ticked = 0;
            public static Graphics render = Graphics.FromImage(FrameBuffer);
        }
        public GamePlay()
        {
            InitializeComponent();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            foreach (OBJ initOBJ in GAME.Current.OBJList)
            {

            }
        }

        private void ticker_Tick(object sender, EventArgs e)
        {

            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            InterpreterState.Ticked++;
            //Main Interpreter cycle
            //InterpreterState.FrameBuffer
            labelTicked.Text = "Tick数: " + InterpreterState.Ticked;
            Pen p = new Pen(Color.Blue, 2);//定义了一个蓝色,宽度为的画笔
            Pen w = new Pen(Color.White, 2);
            InterpreterState.render.DrawLine(p, 10, 10, InterpreterState.Ticked, InterpreterState.Ticked);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
            InterpreterState.render.DrawRectangle(p, 10, 10, InterpreterState.Ticked, InterpreterState.Ticked);//在画板上画矩形,起始坐标为(10,10),宽为,高为

            InterpreterState.render.DrawRectangle(w, 10, 10, InterpreterState.Ticked-10, InterpreterState.Ticked-10);//在画板上画矩形,起始坐标为(10,10),宽为,高为
            InterpreterState.render.DrawEllipse(p, 10, 10, InterpreterState.Ticked, InterpreterState.Ticked);//在画板上画椭圆,起始坐标为(10,10),外接矩形的宽为,高为
            if (comboBoxRefresh.SelectedIndex == 1)
            {
                //InterpreterState.render.Clear(Color.White);
                VRamCopy();
            } else if (comboBoxRefresh.SelectedIndex == 3)
            {
                GamePlay.d
            }


            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void VRamCopy()
        {
            canvas.Image = InterpreterState.FrameBuffer;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelSpeed.Text = "时间速度: "+trackBarSpeed.Value;
            ticker.Interval = trackBarSpeed.Value;
        }

        private void buttonTickStrat_Click(object sender, EventArgs e)
        {

            ticker.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            ticker.Stop();
        }

        private void comboBoxRefresh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSmooth_SelectedIndexChanged(object sender, EventArgs e)
        {
            InterpreterState.render.SmoothingMode = (System.Drawing.Drawing2D.SmoothingMode)comboBoxSmooth.SelectedIndex; 
        }

        private void GamePlay_Paint(object sender, PaintEventArgs e)
        {
            if (comboBoxRefresh.SelectedIndex == 3)
            {
                VRamCopy();
            }
        }
    }
}
