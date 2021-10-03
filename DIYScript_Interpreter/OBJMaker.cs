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
    public partial class OBJMaker : Form
    {
        public delegate void OBJOKHandler(string status);
        event OBJOKHandler OBJMade;
        
        public OBJMaker()
        {
            InitializeComponent();
            checkBox1.Enabled = false;// Just for noob :(
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Int16 StartMode = 0;
            if (radioButton1.Checked) {
                StartMode = 1;
                //fixed
            }
            else if(radioButton2.Checked)
            {
                if (!checkBox1.Checked)
                {
                    StartMode = 2;
                    //any
                }
                else
                {
                    StartMode = 3;
                    //not2overlap
                }
            } else if (OBJChoose.isAttach)
            {
                StartMode = 4;
            }
            OBJAddingStatus.CurrentOBJID++;
            GAME.Current.AddOBJ();
            GAME.Current.EditOBJ
            (OBJAddingStatus.CurrentOBJID, textBoxOBJName.Text, StartMode,
             new Int16[] { (short)trackBar1.Value, (short)trackBar2.Value },
             new Int16[] { (short)trackBar3.Value, (short)trackBar4.Value });
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = radioButton2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form OBJChooseForm = new OBJChooser();
            OBJChooseForm.ShowDialog();
        }

        
    }
}
