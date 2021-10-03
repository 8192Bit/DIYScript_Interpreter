using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYScript_Interpreter {


    public partial class OBJChooser : Form {
        public OBJChooser() {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e) {

            OBJChoose.isAttach = true;
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void listViewOBJ_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void OBJChooser_Load(object sender, EventArgs e) {
            listViewOBJ.Clear();
            foreach (OBJ obj in GAME.Current.OBJList) {

                listViewOBJ.Items.Add(obj.Name, (int)obj.ID);
                //imageList.Images.Add();
            }
        }
    }
}
