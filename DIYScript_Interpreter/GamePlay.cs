using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYScript_Interpreter
{
    public partial class GamePlay : Form
    {
        public static class InterpreterState{
            public static Bitmap FrameBuffer = new Bitmap(640, 480);
            
        }
        public GamePlay()
        {
            InitializeComponent();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            ticker.Start();
            foreach (OBJ initOBJ in GAME.Current.OBJList)
            {

            }
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            //Main Interpreter cycle
            //InterpreterState.FrameBuffer
        }
    }
}
