using System;
using System.Collections.Generic;
using System.Drawing;

namespace DIYScript_Interpreter {
    // put all your classes here!!
    //mariokate
    //:P

    enum TypeCondotions {
        Tap,
        Time,
        Contact,
        Switch,
        Art,
        WinLoss
    }
    enum TypeCommands {
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
        object Arg0;
        object Arg1;
        object Arg2;
        object Arg3;
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
        public Bitmap[] ArtAnimation = new Bitmap[64];
        public int TotalFrames;
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
        public static Graphics graphics = Graphics.FromImage(bitmap);
        public static bool isEdit;
    }
    public class OBJAddingStatus {
        public static UInt64 CurrentOBJID = 0;
        public static bool isEdit;
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
        public UInt64 AttachTargetID;
        public Int16[] AttachOffset = new Int16[2];
        // AttachOffset = {offsetx, offsety}

        public List<OBJArt> ArtList = new List<OBJArt>();
        public int[] OBJSize = new int[2];
        public OBJArt Arts = new OBJArt();
        public OBJArt CurrentArt;

        public List<Script> ScriptList = new List<Script>();

        public void AddArt() {
            OBJArt ART = new OBJArt();
            ArtList.Add(ART);
        }
        public void DelArt(int index) {
            ArtList.RemoveAt(index);
        }


        public class Author {
            public string state;
        }





        void somethingiwanttosay() {
            Author I = new Author();
            I.state = "tired";
            if (I.state != "tired") {
#pragma warning disable IDE1006
                I.state = "say 'fxxu microsoft'";
            }
            I.state = "???" +
                "oh it seemed i did it";
            I.state = "died";
        }

    }
}

