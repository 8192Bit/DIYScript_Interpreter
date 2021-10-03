using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void buttonNewBG_Click(object sender, EventArgs e) {
            openFileDialog.Filter = "位图|*.bmp";
            openFileDialog.FileName = "11145141919810.bmp";
            openFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e) {
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {

            BGMaker bGMaker = new BGMaker();
            BGAddingStatus.bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
            bGMaker.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            OBJAddingStatus.CurrentOBJID = 0;
        }

        private void buttonNewOBJ_Click_1(object sender, EventArgs e) {
            Form OBJ = new OBJMaker();
            OBJ.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void buttonDelOBJ_Click(object sender, EventArgs e) {
            GAME.Current.OBJList.RemoveAt(listViewOBJ.CheckedIndices.Count-1);
        }

        private void 首选项ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form options = new Options();
            options.ShowDialog();
        }

        private void buttonRefreshOBJ_Click(object sender, EventArgs e)
        {
            listViewOBJ.Clear();
            foreach (OBJ obj in GAME.Current.OBJList)
            {

                listViewOBJ.Items.Add(obj.Name, (int)obj.ID);
                //imageList.Images.Add();
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
    //        string str = textEditorControl1.ActiveTextAreaControl.SelectionManager.SelectedText;
      //      if (str == "") return;
        //    Clipboard.SetText(str);
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Clipboard.GetText();
 //           textEditorControl1.ActiveTextAreaControl.TextArea.InsertString(str);
 //
   //         if (textEditorControl1.ActiveTextAreaControl.SelectionManager.HasSomethingSelected)
     //           textEditorControl1.ActiveTextAreaControl.SelectionManager.RemoveSelectedText();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 //           string str = textEditorControl1.ActiveTextAreaControl.SelectionManager.SelectedText;
   //         if (str == "") return;
     //       Clipboard.SetText(str);
       //     textEditorControl1.ActiveTextAreaControl.SelectionManager.RemoveSelectedText();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            string str = textEditorControl1.ActiveTextAreaControl.SelectionManager.SelectedText;
  //          if (str != "") textEditorControl1.ActiveTextAreaControl.SelectionManager.RemoveSelectedText();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            this.textEditorControl1.ActiveTextAreaControl.SelectionManager.SetSelection(
  //              textEditorControl1.Document.OffsetToPosition(0),
    //            textEditorControl1.Document.OffsetToPosition(textEditorControl1.Document.TextLength));
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printer = new PrintDocument();
            printer.Print();
        }
    }

    public class OBJChoose {
        public static bool isAttach;
        public static OBJ ChoosedOBJ;
    }
    public class OBJArt {
        public Bitmap[] ArtAnimation = new Bitmap[64];
        public int TotalFrames;
        public int CurrentFrame;
    }

    public class GAME {
        public static GAME Current = new GAME();
        public List<OBJ> OBJList = new List<OBJ>();
        public List<BG> BGList = new List<BG>();
        internal void AddOBJ() {
            OBJ OBJ = new OBJ();

            OBJList.Add(OBJ);
        }

        internal void EditOBJ(UInt64 index, string Name, Int16 StartMode, Int16[] SX, Int16[] SY) {
            OBJList[(int)index-1].Name = Name;
            OBJList[(int)index-1].StartMode = StartMode;
            OBJList[(int)index-1].StrtX = SX;
            OBJList[(int)index-1].StrtY = SY;
        }
        internal void DelArt(int index) {
            OBJList.RemoveAt(index);
        }
        internal void AddBG() {
            BG BG = new BG();
            BGList.Add(BG);
        }
        internal void DelBG(int index) {
            BGList.RemoveAt(index);
        }
    }
    public class BG {
        public UInt64 ID;
        public Bitmap bitmap;
        public string Name;
        public int[] Resolution = new int[2];
        public void Refresh() {

        }
    }
    public class BGAddingStatus {
        public static UInt64 CurrentBGID;
        public static Bitmap bitmap;
    }
    public class OBJAddingStatus {
        public static UInt64 CurrentOBJID;

    }
    public class OBJ {
        public UInt64 ID;
        public string Name;
        public Int16 PosX;
        public Int16 PosY;
        public Int16 StartMode;
        // 1 == Location, Point
        // 2 == Location, Area, Anywhere
        // 3 == Location, Area, Try not to overlap
        // 4 == Attath to OBJ
        public Int16[] StrtX = new Int16[2];
        public Int16[] StrtY = new Int16[2];
        // If StartMode == 1, StrtX[] = {x1, x2}, StrtY[] = {y1, y2}
        // If StartMode == 2/3, StrtX[] = {x, null}, StrtY[] = {y, null}
        public UInt64 AttachTargetID;
        public Int16[] AttachOffset = new Int16[2];
        // AttachOffset = {offsetx, offsety}
        public bool[] Switch = new bool[4];
        // Switch A, B, C, D
        public int[] OBJSize = new int[2];
        public OBJArt Arts = new OBJArt();
        public OBJArt CurrentArt;
        public int Rotation = 0;
        public int[] Scale = new int[2];
        // Scale = {XScale, YScale}
        // rotate z axis == decrease scale X axis.
        // Yeah.:)
        public List<OBJArt> ArtList = new List<OBJArt>();

        public void AddArt() {
            OBJArt ART = new OBJArt();
            ArtList.Add(ART);
        }
        public void DelArt(int index) {
            ArtList.RemoveAt(index);
        }

    }
}
