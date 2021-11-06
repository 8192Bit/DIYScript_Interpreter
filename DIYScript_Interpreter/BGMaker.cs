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
    public partial class BGMaker : Form
    {
        public BGMaker()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                GAME.Current.AddBG(BGAddingStatus.bitmap, textBoxBGName.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("SystemERR. DEAD-END-CODE = " + ex.GetType());
                Console.WriteLine();
            }
            Close();

        }

        private void BGMaker_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = BGAddingStatus.bitmap;
        }
    }
}
