using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DIYScript_Interpreter {

    public class Object {
        public string Name;
        public ulong ID;
    }
    public enum StartMode {
        Point,
        AreaAnywhere,
        AreaNotOverlap,
        Attach
    }
    public enum Directions {
        w,//←
        n,//↑
        e,//→
        s,//↓
        nw,//↖
        ne,//↗
        se,//↘
        sw //↙

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
    public class INIOperation {
        private string path;
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
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", temp, 255, path);
            return temp.ToString();
        }


    }
    public class Script {
        public List<Condition> Conditions;
        public List<Command> Commands;
    }
    public class Command {
#pragma warning disable CS0169 // 从不使用字段“Command.OPCode”
        private TypeCommands OPCode;
#pragma warning restore CS0169 // 从不使用字段“Command.OPCode”
#pragma warning disable CS0169 // 从不使用字段“Command.Arg0”
        private int Arg0;
#pragma warning restore CS0169 // 从不使用字段“Command.Arg0”
#pragma warning disable CS0169 // 从不使用字段“Command.Arg1”
        private int Arg1;
#pragma warning restore CS0169 // 从不使用字段“Command.Arg1”
#pragma warning disable CS0169 // 从不使用字段“Command.Arg2”
        private int Arg2;
#pragma warning restore CS0169 // 从不使用字段“Command.Arg2”
#pragma warning disable CS0169 // 从不使用字段“Command.Arg3”
        private int Arg3;
#pragma warning restore CS0169 // 从不使用字段“Command.Arg3”
        string getDescribe() {
            return "114514";
        }
    }
    public class Condition {
#pragma warning disable CS0169 // 从不使用字段“Condition.OPCode”
        private TypeCondotions OPCode;
#pragma warning restore CS0169 // 从不使用字段“Condition.OPCode”
#pragma warning disable CS0169 // 从不使用字段“Condition.Arg0”
        private int Arg0;
#pragma warning restore CS0169 // 从不使用字段“Condition.Arg0”
#pragma warning disable CS0169 // 从不使用字段“Condition.Arg1”
        private int Arg1;
#pragma warning restore CS0169 // 从不使用字段“Condition.Arg1”
#pragma warning disable CS0169 // 从不使用字段“Condition.Arg2”
        private int Arg2;
#pragma warning restore CS0169 // 从不使用字段“Condition.Arg2”
#pragma warning disable CS0169 // 从不使用字段“Condition.Arg3”
        private int Arg3;
#pragma warning restore CS0169 // 从不使用字段“Condition.Arg3”
    }
    public class Document {
        public static Document Current = new Document();

        public List<OBJ> OBJList = new List<OBJ>();
        public List<BG> BGList = new List<BG>();

        internal void AddOBJ() {
            OBJ OBJ = new OBJ();
            OBJList.Add(OBJ);
        }

        internal void DelArt(int index) {
            OBJList.RemoveAt(index);
        }
        internal void AddBG(Bitmap bitmap, string name) {
            BGAddingStatus.CurrentBGID++;
            BG bg = new BG();
            BGList.Add(bg);
            bg.bitmap = bitmap;
            bg.Name = name;
            bg.ID = BGAddingStatus.CurrentBGID;
        }
        internal void DelBG(int index) {
            BGList.RemoveAt(index);
        }
    }
    public class OBJ : Object {

        public short PosX;
        public short PosY;
        public bool[] Switch = new bool[4];
        // Switch A, B, C, D
        public int Rotation = 0;
        public int[] Scale = new int[2];
        // Scale = {XScale, YScale}
        // rotate z axis == decrease scale X axis.
        public StartMode startMode;
        public short[] StrtX = new short[2];
        public short[] StrtY = new short[2];
        // If StartMode == 1, StrtX[] = {x1, x2}, StrtY[] = {y1, y2}
        // If StartMode == 2 or 3, StrtX[] = {x, null}, StrtY[] = {y, null}
        // If StartMode == 4, StrtX[] = {offsetx, null}, StrtY[]={offsety, null}
        public ulong AttachOBJID;
        public List<OBJArt> ArtList = new List<OBJArt>();
        public OBJArt CurrentArt;
        public List<Script> ScriptList = new List<Script>();
    }
    public class OBJArt : Object {
        public ImageList i = new ImageList();
        public int CurrentFrame;
        public bool isNormal;
    }
    public class BG : Object {
        public Bitmap bitmap;
        public bool isNormal;
    }
    public class BGAddingStatus {
        public static ulong CurrentBGID = 0;
    }

    public class OBJAddingStatus {
        public static ulong CurrentOBJID = 0;
        public static bool isEdit;
        public static int[] MouseState = { 0, 0, 0, 0, 0 }; //{StartX,StartY,EndX,EndY,isDown}
        public static Directions direction;
        public static OBJ OBJTemp;
    }

    public class OBJArtAddingStatus {
        public static ulong CurrentOBJArtID = 0;
    }

    public class OBJChoose {
        public static bool isAttach;
        public static OBJ ChoosedOBJ;
    }

    public class Importing {
        public static Bitmap canvasContent = new Bitmap(640, 480);
        public static Graphics gdraw = Graphics.FromImage(canvasContent);
    }

    public class ZipOperation {
        public static void CompressDirectory(string dirPath, string GzipFileName, bool deleteDir) {
            //压缩文件路径
            string pCompressPath = dirPath + ".zip";
            //创建压缩文件
            FileStream pCompressFile = new FileStream(pCompressPath, FileMode.Create);
            using (ZipOutputStream zipoutputstream = new ZipOutputStream(pCompressFile)) {
                Crc32 crc = new Crc32();
                Dictionary<string, DateTime> fileList = GetAllFies(dirPath);
                foreach (KeyValuePair<string, DateTime> item in fileList) {
                    FileStream fs = new FileStream(item.Key.ToString(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    // FileStream fs = File.OpenRead(item.Key.ToString());
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    ZipEntry entry = new ZipEntry(item.Key.Substring(dirPath.Length));
                    entry.DateTime = item.Value;
                    entry.Size = fs.Length;
                    fs.Close();
                    crc.Reset();
                    crc.Update(buffer);
                    entry.Crc = crc.Value;
                    zipoutputstream.PutNextEntry(entry);
                    zipoutputstream.Write(buffer, 0, buffer.Length);
                }
            }
            if (deleteDir) {
                Directory.Delete(dirPath, true);
            }
        }
        ///    
        /// 获取所有文件   
        ///    
        ///    
        private static Dictionary<string, DateTime> GetAllFies(string dir) {
            Dictionary<string, DateTime> FilesList = new Dictionary<string, DateTime>();
            DirectoryInfo fileDire = new DirectoryInfo(dir);
            if (!fileDire.Exists) {
                throw new System.IO.FileNotFoundException("目录:" +fileDire.FullName + "没有找到!");
            }
            GetAllDirFiles(fileDire, FilesList);
            GetAllDirsFiles(fileDire.GetDirectories(), FilesList);
            return FilesList;
        }
        ///    
        /// 获取一个文件夹下的所有文件夹里的文件   
        ///    
        ///    
        ///    
        private static void GetAllDirsFiles(DirectoryInfo[] dirs, Dictionary<string, DateTime> filesList) {
            foreach (DirectoryInfo dir in dirs) {
                foreach (FileInfo file in dir.GetFiles(".")) {
                    filesList.Add(file.FullName, file.LastWriteTime);
                }
                GetAllDirsFiles(dir.GetDirectories(), filesList);
            }
        }
        ///    
        /// 获取一个文件夹下的文件   
        ///    
        /// 目录名称   
        /// 文件列表HastTable   
        private static void GetAllDirFiles(DirectoryInfo dir, Dictionary<string, DateTime> filesList) {
            foreach (FileInfo file in dir.GetFiles()) {
                filesList.Add(file.FullName, file.LastWriteTime);
            }
        }
    }
}

