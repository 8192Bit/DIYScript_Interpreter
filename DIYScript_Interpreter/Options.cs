using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor;

namespace DIYScript_Interpreter
{
    public partial class Options : Form
    {

        public Options()
        {
            InitializeComponent();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            buttonFont.Font = fontDialog1.Font;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewExample.View = (View)comboBox1.SelectedIndex;
        }

        private void buttonCFront_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonCFront.ForeColor = colorDialog1.Color;
            textEditorControl1.ForeColor = colorDialog1.Color;
        }

        private void buttonCBG_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            buttonCBG.ForeColor = colorDialog2.Color;
            textEditorControl1.BackColor = colorDialog2.Color;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textEditorControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
