﻿using System;
using System.Windows.Forms;
using static DIYScript_Interpreter.Document;
#pragma warning disable IDE1006
//Fxxk u microsoft ide1006 is the silliest suggestion in all of the ides
//they hate a name which generated by itself
//Damnit

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
            foreach(OBJ obj in Current.OBJList) {
                listViewOBJ.Items.Add(obj.Name, (int)obj.ID);
                //imageList.Images.Add();
            }
        }
    }
}
