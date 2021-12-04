using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    // put all your classes here!!
    //mariokate
    //:P

    public class INIOperation {
        string path;
        public INIOperation(string path) {
            this.path = path;
        }
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

        ///<summary>
        ///向ini文件中写数据
        ///</summary>
        ///<param name="Section">节点</param>
        ///<param name="Key">键</param>
        ///<param name="Value">值</param>
        public void WriteValue(string Section, string Key, string Value) {
            WritePrivateProfileString(Section, Key, Value, path);
        }
        ///<summary>
        ///从ini文件中读数据
        ///</summary>
        ///<param name="Section">节点</param>
        ///<param name="Key">键</param>
        ///<returns>值</returns>
        public string ReadValue(string Section, string Key) {
            StringBuilder temp = new StringBuilder(255); GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }


    }



    public enum Directions {
        w,
        n,
        e,
        s,
        nw,
        ne,
        se,
        sw
        //←↑→↓↖↗↘↙
    }
    public enum TypeCondotions {
        Tap,
        Time,
        Contact,
        Switch,
        Art,
        WinLoss
    }
    public enum TypeCommands {
        Travel,
        Switch,
        Lose,
        Art,
        SFX,
        VFX
    }
    public class Condition {
        TypeCondotions OPCode;
        int Arg0;
        int Arg1;
        int Arg2;
        int Arg3;
    }
    public class Command {
        TypeCommands OPCode;
        int Arg0;
        int Arg1;
        int Arg2;
        int Arg3;
    }
    public class Script {
        public List<Condition> Conditions;
        public List<Command> Commands;
    }

    public class OBJChoose {
        public static bool isAttach;
        public static OBJ ChoosedOBJ;
    }
    public class OBJArt {
        public UInt64 ID;
        public ImageList i = new ImageList();
        public int CurrentFrame;
    }

    public class GAME {

        public GamePlay player = new GamePlay();
        public static GAME Current = new GAME();
        public List<OBJ> OBJList = new List<OBJ>();
        public List<BG> BGList = new List<BG>();
        internal void AddOBJ() {
            OBJ OBJ = new OBJ();

            OBJList.Add(OBJ);
        }

        internal void EditOBJ(UInt64 index, string Name, Int16 StartMode, Int16[] SX, Int16[] SY) {
            OBJList[(int)index - 1].Name = Name;
            OBJList[(int)index - 1].StartMode = StartMode;
            OBJList[(int)index - 1].StrtX = SX;
            OBJList[(int)index - 1].StrtY = SY;
        }
        internal void DelArt(int index) {
            OBJList.RemoveAt(index);
        }
        internal void AddBG(Bitmap bitmap, string name) {
            BGAddingStatus.CurrentBGID++;
            BG BG = new BG();
            BGList.Add(BG);
            BG.bitmap = bitmap;
            BG.Name = name;
            BG.ID = BGAddingStatus.CurrentBGID;
            BG.Resolution[0] = BGAddingStatus.bitmap.Width;
            BG.Resolution[1] = BGAddingStatus.bitmap.Height;
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
        public bool isNormal;

       }
    
    public class BGAddingStatus {
        public static UInt64 CurrentBGID = 0;
        public static Bitmap bitmap;
        public static Bitmap temp = new Bitmap(640, 480);
        public static Graphics gt = Graphics.FromImage(temp);
    }
    public class OBJAddingStatus {
        public static UInt64 CurrentOBJID = 0;
        public static bool isEdit;
        public static int[] MouseState = { 0, 0, 0, 0, 0 }; //{StartX,StartY,EndX,EndY,isDown}
        public static Directions direction;
    }
    public class OBJ {
        public UInt64 ID;
        public string Name;


        public Int16 PosX;
        public Int16 PosY;
        public bool[] Switch = new bool[4];
        // Switch A, B, C, D
        public int Rotation = 0;
        public int[] Scale = new int[2];
        // Scale = {XScale, YScale}
        // rotate z axis == decrease scale X axis.
        // Yeah.:)

        public Int16 StartMode;
        // 1 == Location, Point
        // 2 == Location, Area, Anywhere
        // 3 == Location, Area, Try not to overlap
        // 4 == Attath to OBJ
        public Int16[] StrtX = new Int16[2];
        public Int16[] StrtY = new Int16[2];
        // If StartMode == 1, StrtX[] = {x1, x2}, StrtY[] = {y1, y2}
        // If StartMode == 2/3, StrtX[] = {x, null}, StrtY[] = {y, null}
        // If StartMode == 4, StrtX[] = {offsetx, null}, StrtY[]={offsety, null}
        public UInt64 AttachOBJID;
        public List<OBJArt> ArtList = new List<OBJArt>();
        public int[] OBJSize = new int[2];
        public OBJArt CurrentArt;

        public List<Script> ScriptList = new List<Script>();

    }
}

