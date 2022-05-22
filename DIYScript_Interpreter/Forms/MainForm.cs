using DIYScript_Interpreter.Properties;
using System;
using System.Media;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.GZip;
using static DIYScript_Interpreter.Document;



namespace DIYScript_Interpreter {
    public partial class MainForm : Form {

        bool isDebugMode = false;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            OBJAddingStatus.CurrentOBJID = 0;
            OptionsRefresh();
        }
        private void OptionsRefresh() {
            listViewBG.View = listViewOBJ.View = listViewBGM.View = Settings.Default.LViewValue;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e) {

            string FilePath = Directory.GetCurrentDirectory() + @"\TempDir";
            string DynaPath = FilePath;
            if (!Directory.Exists(FilePath)) {
                Directory.CreateDirectory(FilePath);// mkdir TempDir
                                                    //cd TempDir
            } else {
                MessageBox.Show("已经发现临时编译文件。" + "\r" + "是否覆盖？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                try {
                    Directory.Delete(FilePath, true);
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }


            #region =Save File Structure=

            ///<summary>
            ///===========Start file making.===========
            ///
            ///please watch the following figure:
            ///📁TempDir
            ///     📄MetaFile.ini
            ///     📁OBJ
            ///         📁0
            ///             📄MetaFile.ini
            ///             📁ART
            ///                  📁0
            ///                    📄0.bmp
            ///                    📄1.bmp
            ///                    ......
            ///                  📁1
            ///                  ......
            ///         📁1
            ///         ......
            ///     📁BG
            ///         📁0
            ///             📄MetaFile.ini
            ///             📄index.bmp
            ///         📁1
            ///         ......
            ///     📁BGM
            ///     ///............///
            /// 
            ///      
            ///</summary>
            #endregion

            #region =Metafile=
            INIOperation configwriter = new INIOperation(FilePath + @"\MetaFile.ini");//cat
            configwriter.WriteValue("GameID", "Name", textBoxGameName.Text);//some working
            configwriter.WriteValue("GameID", "Comment", textBoxComment.Text);
            string temp;
            if (radioButtonSpeedQ.Checked) {
                temp = "Q";
            } else if (radioButtonSpeedM.Checked) {
                temp = "M";
            } else if (radioButtonSpeedS.Checked) {
                temp = "S";
            } else {
                temp = "not_set_yet";
            }
            configwriter.WriteValue("GameSetting", "Speed", temp);
            if (checkBoxTimeBOSS.Checked) {
                configwriter.WriteValue("GameSetting", "LastTime", "-1");
            } else if (maskedTextBoxTime.Text != "      ms") {

                configwriter.WriteValue("GameSetting", "LastTime", maskedTextBoxTime.Text.ToString());
            } else {

                configwriter.WriteValue("GameSetting", "LastTime", "not_set_yet");
            }
            #endregion

            #region =OBJ=
            DynaPath += @"\OBJ";
            Directory.CreateDirectory(FilePath);//mkdir OBJ
                                                //cd OBJ


            foreach (OBJ obj in Current.OBJList) {
                DynaPath += @"\" + obj.ID.ToString();
                Directory.CreateDirectory(DynaPath);

                //OBJ ini maker.

                INIOperation OBJdefiner = new INIOperation(DynaPath + @"\OBJDefine.ini");
                OBJdefiner.WriteValue("OBJID", "Name", obj.Name);
                //OBJdefiner.WriteValue("OBJID", "");
                //and then something about scripts......


                //Start art writing...

                DynaPath += @"\ART";
                Directory.CreateDirectory(DynaPath);
                foreach (OBJArt art in obj.ArtList) {
                    DynaPath += @"\ART" + art.ID.ToString();
                    foreach (Image s in art.i.Images) {

                        FileStream fs = new FileStream(DynaPath + s.ToString(), FileMode.OpenOrCreate);
                        s.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);

                        fs.Dispose();
                    }
                    DynaPath = FilePath + @"\ART";
                }


                //I didnt learn *nix Shell Operation well...:(

            }

            #endregion

            #region =BG=(finished!!)
            DynaPath = FilePath + @"\BG";

            Directory.CreateDirectory(DynaPath);
            {
                foreach (BG bg in Current.BGList) {
                    DynaPath += @"\BG" + bg.ID.ToString();
                    Directory.CreateDirectory(DynaPath);
                    //BGs INI define.
                    INIOperation BGDefinder = new INIOperation(DynaPath + @"\BGDefine.ini");
                    BGDefinder.WriteValue("BGID", "Name", bg.Name);
                    BGDefinder.WriteValue("BGID", "ID", bg.ID.ToString());
                    BGDefinder.WriteValue("BGID", "isNorm", bg.isNormal.ToString());
                    FileStream fs = new FileStream(DynaPath + @"\index.bmp", FileMode.OpenOrCreate);
                    bg.bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    fs.Dispose();

                    DynaPath = FilePath + @"\BG";
                }
            }
            #endregion


            ZipOperation.CompressDirectory(Directory.GetCurrentDirectory() + @"\TempDir", null, true);



            FileInfo fi = new FileInfo(Directory.GetCurrentDirectory() + @"\TempDir.zip");

            fi.CopyTo(saveFileDialogPj.FileName, true);
            
            
        }

        #region Section GamePlay

        public void NUT_Click(object sender, EventArgs e) {
            GamePlay player = new GamePlay();
            player.Show();
            Hide();
        }

        private void Run_Click(object sender, EventArgs e) {
            NUT.PerformClick();
        }

        #endregion

        #region Section BG

        private void listViewBG_SelectedIndexChanged(object sender, EventArgs e) {
            buttonNormalBG.Enabled = Current.BGList[listViewBG.FocusedItem.Index].isNormal ? false : true;
        }

        private void buttonRefreshBG_Click(object sender, EventArgs e) {
            listViewBG.Clear();
            imageListBGSmall.Images.Clear();
            imageListBGLarge.Images.Clear();
            foreach (BG bg in Current.BGList) {
                imageListBGSmall.Images.Add(bg.bitmap);
                imageListBGLarge.Images.Add(bg.bitmap);
                if (isDebugMode) {
                    listViewBG.Items.Add(bg.Name + "( ID = " + bg.ID + " )", Current.BGList.IndexOf(bg));
                } else {
                    listViewBG.Items.Add(bg.Name, Current.BGList.IndexOf(bg));
                }
            }
        }

        private void buttonDeleteBG_Click(object sender, EventArgs e) {
            try {
                Current.BGList.RemoveAt(listViewBG.FocusedItem.Index);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            buttonRefreshBG.PerformClick();
        }

        #region newBG
        private void buttonNewBG_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
            buttonRefreshBG.PerformClick();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            if (!e.Cancel) {
                Importer importer = new Importer();
                importer.setFile(Path.GetFileNameWithoutExtension(openFileDialog.FileName), Image.FromFile(openFileDialog.FileName));
                importer.ShowDialog();
            }
        }
        #endregion

        #endregion

        #region Section OBJ
        public void OBJRefresh() {
            foreach (OBJ obj in Current.OBJList) {
                listViewOBJ.Clear();
                listViewOBJ.Items.Add(obj.Name + "( ID = " + obj.ID + " )", (int)obj.ID);
                //imageList.Images.Add();
            }
        }

        private void buttonNewOBJ_Click_1(object sender, EventArgs e) {
            OBJAddingStatus.isEdit = false;
            Form OBJ = new OBJMaker();
            OBJ.ShowDialog();
            buttonRefreshOBJ.PerformClick();
        }

        private void buttonEditOBJ_Click(object sender, EventArgs e) {
            OBJMaker obj = new OBJMaker();
            OBJAddingStatus.isEdit = true;
            obj.setOBJtoEdit(Current.OBJList[listViewOBJ.FocusedItem.Index]);
            OBJAddingStatus.CurrentOBJID = Current.OBJList[listViewOBJ.FocusedItem.Index].ID;
            obj.ShowDialog();
            buttonRefreshOBJ.PerformClick();
        }
        private void buttonDelOBJ_Click(object sender, EventArgs e) {
            Current.OBJList.RemoveAt(listViewOBJ.FocusedItem.Index);
        }



        private void buttonRefreshOBJ_Click(object sender, EventArgs e) {
            listViewOBJ.Clear();
            foreach (OBJ obj in Current.OBJList) {

                listViewOBJ.Items.Add(obj.Name, (int)obj.ID);
                //imageList.Images.Add();
            }
        }

        private void listViewOBJ_SelectedIndexChanged(object sender, EventArgs e) {
            labelOBJName.Text = Current.OBJList[listViewOBJ.FocusedItem.Index].Name;
            if (listViewOBJ.FocusedItem.Equals(null)) {
                labelOBJName.Text = "未选中对象";
            }
        }
        #endregion

        #region Section AI
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxArea.Checked) {
                checkBoxArea.Text = "此OBJ";
            } else {
                checkBoxArea.Text = "关卡的任意位置";
            }
        }
        private void CommandRefresh() {
            listBoxScript.Items.Clear();
            OBJ obj = Current.OBJList[listViewOBJ.FocusedItem.Index];
            Script scr = obj.ScriptList[114514];
            try {
                foreach (Command com in scr.Commands) {

                }
                foreach (Condition con in scr.Conditions) {

                }
            } catch { }
            listBoxScript.Items.Add(scr.ToString());

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
        private void buttonAdd_Click(object sender, EventArgs e) {

            try {
                Current.OBJList[listViewOBJ.FocusedItem.Index].ScriptList.Add(new Script());
            } catch {

            }
            CommandRefresh();
        }
        private void buttonDel_Click(object sender, EventArgs e) {

        }

        private void AI_Click(object sender, EventArgs e) {

        }


        private void CTap_Click(object sender, EventArgs e) {

        }


        private void comboBoxClickSlide_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxClickSlide.SelectedIndex == 0) {
                pictureBoxCS.Image = Resources.Click;
                radioButtonTapN.Enabled = false;
                radioButtonTapS.Enabled = false;
                radioButtonTapW.Enabled = false;
                radioButtonTapE.Enabled = false;
                radioButtonTapNW.Enabled = false;
                radioButtonTapNE.Enabled = false;
                radioButtonTapSW.Enabled = false;
                radioButtonTapSE.Enabled = false;
            } else {
                pictureBoxCS.Image = Resources.Slide;
                radioButtonTapN.Enabled = true;
                radioButtonTapS.Enabled = true;
                radioButtonTapW.Enabled = true;
                radioButtonTapE.Enabled = true;
                radioButtonTapNW.Enabled = true;
                radioButtonTapNE.Enabled = true;
                radioButtonTapSW.Enabled = true;
                radioButtonTapSE.Enabled = true;

            }

        }

        private void buttonCOK_Click(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {
            if (checkBoxSONOFF.Checked == true) {

                checkBoxSONOFF.Image = Resources.ON;

            } else {
                checkBoxSONOFF.Image = Resources.OFF;
            }
        }

        private void checkBoxTISRandom_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxTISRandom.Checked == true) {
                checkBoxTISRandom.Text = "区域随机";
                trackBarTTO.Enabled = true;
            } else {

                checkBoxTISRandom.Text = "准确时间";
                trackBarTTO.Enabled = false;
            }
        }

        private void trackBarTTO_Scroll(object sender, EventArgs e) {
            if (trackBarTTO.Value < trackBarTTFROM.Value && trackBarTTO.Enabled) {
                trackBarTTO.Value = trackBarTTFROM.Value;
            }
        }

        private void checkBoxWL_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxWL.Checked == true) {
                checkBoxWL.Text = "成功";
            } else {
                checkBoxWL.Text = "失败";
            }
        }



        private void tabControlT_TabIndexChanged(object sender, EventArgs e) {
            if (tabControlT.SelectedTab.Text == "停止") {
                comboBoxTTType.Enabled = false;
                comboBoxTSpeed.Enabled = false;
            } else {
                comboBoxTTType.Enabled = true;

                comboBoxTSpeed.Enabled = true;
            }
        }

        private void buttonCSChoose_Click(object sender, EventArgs e) {
            OBJChooser ch = new OBJChooser();
            ch.Show();
        }

        private void comboBoxTTType_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBoxTTType.SelectedIndex) {
                case 0:
                    pictureBoxTS.Image = Resources.none;
                    break;
                case 1:
                    pictureBoxTS.Image = Resources.linear;
                    break;
                case 2:
                    pictureBoxTS.Image = Resources.square;
                    break;
                case 3:
                    pictureBoxTS.Image = Resources.log;
                    break;
                case 4:
                    pictureBoxTS.Image = Resources.smooth;
                    break;
                case 5:
                    pictureBoxTS.Image = Resources.stay;
                    break;
            }
        }

        private void buttonTOOBJChoose_Click(object sender, EventArgs e) {
            OBJChooser chooser = new OBJChooser();
            chooser.Show();
        }

        #endregion

        #region Section Metadata


        private void checkBoxTimeBOSS_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxTimeBOSS.Checked) {
                maskedTextBoxTime.Enabled = false;
            } else {
                maskedTextBoxTime.Enabled = true;
            }
        }

        #endregion

        #region Section Music
        private void buttonNewBGM_Click(object sender, EventArgs e) {
            SoundPlayer sp = new SoundPlayer(Resources.Roll);
            sp.Play();
        }
        #endregion

        #region Section toolStrip
        private void toolStripButton1_Click(object sender, EventArgs e) {
            isDebugMode = !isDebugMode;
            if (isDebugMode) {
                toolStripButton1.ForeColor = Color.Green;
            } else {
                toolStripButton1.ForeColor = Color.White;
            }
            buttonRefreshOBJ.PerformClick();
            buttonRefreshBG.PerformClick();
            // debug
        }
        #region File
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialogPj.ShowDialog();
        }
        private void File_Click(object sender, EventArgs e) {
            File.ForeColor = Color.Black;
        }

        private void File_MouseLeave(object sender, EventArgs e) {
            File.ForeColor = Color.White;
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) {
            Dispose();
        }


        #endregion
        #region Option
        private void Option_Click(object sender, EventArgs e) {
            Option.ForeColor = Color.Black;
        }

        private void Option_MouseLeave(object sender, EventArgs e) {
            Option.ForeColor = Color.White;
        }

        private void 首选项ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form options = new Options();
            options.ShowDialog();
            OptionsRefresh();
        }
        #endregion
        #region Help
        private void Help_Click(object sender, EventArgs e) {
            Help.ForeColor = Color.Black;
        }

        private void Help_MouseLeave(object sender, EventArgs e) {
            Help.ForeColor = Color.White;
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form About = new AboutBox();
            About.ShowDialog();
        }
        #endregion

        #endregion


    }

}
