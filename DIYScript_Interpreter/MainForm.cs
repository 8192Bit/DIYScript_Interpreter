﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static DIYScript_Interpreter.GAME;
using System.Resources;
using System.IO;
using System.Runtime.InteropServices;


#pragma warning disable IDE1006
//Fxxk u microsoft ide1006 is the silliest suggestion in all of the ides
//they hate a name which generated by itself
//Damnit

namespace DIYScript_Interpreter {


    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        public void OBJRefresh() {
            foreach (OBJ obj in GAME.Current.OBJList) {
                listViewOBJ.Clear();
                listViewOBJ.Items.Add(obj.Name, (int)obj.ID);
                //imageList.Images.Add();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void 程序帮助ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form About = new AboutBox();
            About.ShowDialog();
        }


        private void 首选项ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form options = new Options();
            options.ShowDialog();
            OptionsRefresh();
        }

        private void buttonNewBG_Click(object sender, EventArgs e) {
            openFileDialog.Filter = "位图|*.bmp";
            openFileDialog.FileName = "11145141919810.bmp";
            openFileDialog.ShowDialog();
            buttonRefreshBG.PerformClick();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e) {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(
 string section, string key, string val
, string filePath);
            string FilePath = saveFileDialogPj.FileName.ToString().Substring(0, saveFileDialogPj.FileName.ToString().LastIndexOf("\\"))+@"\TempDir";
            if (!Directory.Exists(FilePath)) {
                Directory.CreateDirectory(FilePath);
            } else {
                MessageBox.Show("已经发现临时编译文件。"+"\r"+"是否覆盖？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }


            FileStream MetaFile = new FileStream(FilePath + @"\MetaFile.ini",FileMode.CreateNew);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {

            BGMaker bGMaker = new BGMaker();
            BGAddingStatus.bitmap = Image.FromFile(openFileDialog.FileName) as Bitmap;
            bGMaker.ShowDialog();
        }
        private void OptionsRefresh() {
            listViewBG.View = listViewOBJ.View = listView1.View = Properties.Settings.Default.LViewValue;

        }
        private void MainForm_Load(object sender, EventArgs e) {
            OBJAddingStatus.CurrentOBJID = 0;
            listViewBG.View = listViewOBJ.View = listView1.View = Properties.Settings.Default.LViewValue;

        }

        private void buttonNewOBJ_Click_1(object sender, EventArgs e) {
            OBJAddingStatus.isEdit = false;
            Form OBJ = new OBJMaker();
            OBJ.ShowDialog();
            buttonRefreshOBJ.PerformClick();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void buttonDelOBJ_Click(object sender, EventArgs e) {
            GAME.Current.OBJList.RemoveAt(listViewOBJ.FocusedItem.Index);
        }



        private void buttonRefreshOBJ_Click(object sender, EventArgs e) {
            listViewOBJ.Clear();
            foreach (OBJ obj in GAME.Current.OBJList) {

                listViewOBJ.Items.Add(obj.Name, (int)obj.ID);
                //imageList.Images.Add();
            }
        }


        private void buttonRefreshBG_Click(object sender, EventArgs e) {
            listViewBG.Clear();
            imageListBGSmall.Images.Clear();
            imageListBGLarge.Images.Clear();
            foreach (BG bg in GAME.Current.BGList) {
                imageListBGSmall.Images.Add(bg.bitmap);
                imageListBGLarge.Images.Add(bg.bitmap);
                listViewBG.Items.Add(bg.Name, Current.BGList.IndexOf(bg));

            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void buttonDeleteBG_Click(object sender, EventArgs e) {
            try {
                Current.BGList.RemoveAt(listViewBG.FocusedItem.Index);
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        public void NUT_Click(object sender, EventArgs e) {
            GAME.Current.player.Show();
        }

        private void Run_Click(object sender, EventArgs e) {
            NUT.PerformClick();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {

            Script scr = new Script();
            Current.OBJList[listViewOBJ.FocusedItem.Index].ScriptList.Add(scr);
            CommandRefresh();
        }

        private void buttonDel_Click(object sender, EventArgs e) {

        }

        private void listViewOBJ_SelectedIndexChanged(object sender, EventArgs e) {
            labelOBJName.Text = Current.OBJList[listViewOBJ.FocusedItem.Index].Name;
        }

        private void buttonEditBG_Click(object sender, EventArgs e) {
            openFileDialog.Filter = "位图|*.bmp";
            openFileDialog.FileName = "11145141919810.bmp";
            openFileDialog.ShowDialog();
            buttonRefreshBG.PerformClick();
        }

        private void buttonEditOBJ_Click(object sender, EventArgs e) {
            Form OBJ = new OBJMaker();
            OBJAddingStatus.isEdit = true;
            OBJ.ShowDialog();
            buttonRefreshOBJ.PerformClick();
        }
        private void CommandRefresh() {
            listBoxScript.Items.Clear();
            foreach (OBJ obj in Current.OBJList) {
                foreach (Script scr in obj.ScriptList) {
                    foreach (Command com in scr.Commands) {

                    }

                    listBoxScript.Items.Add(scr.ToString());

                }
            }
        }
        private void buttonCAdd_Click(object sender, EventArgs e) {
        }

        private void buttonNormalBG_Click(object sender, EventArgs e) {
            foreach (BG bg in Current.BGList) {
                bg.isNormal = false;
            }

            Current.BGList[listViewBG.FocusedItem.Index].isNormal = true;
            buttonNormalBG.Enabled = false;
        }

        private void listViewBG_SelectedIndexChanged(object sender, EventArgs e) {
            if (Current.BGList[listViewBG.FocusedItem.Index].isNormal == true) {
                buttonNormalBG.Enabled = false;
            } else {
                buttonNormalBG.Enabled = true;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialogPj.ShowDialog();
        }
    }

}
