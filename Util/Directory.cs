using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaveImageSerial.Util
{
    internal static class Directory
    {
        static public string getSaveDirectory()
        {
            string saveDir = "";
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "保存先のフォルダー";
            FBD.SelectedPath = @"C:";
            FBD.ShowNewFolderButton = true;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(FBD.SelectedPath);
                saveDir = FBD.SelectedPath;
            }
            else
            {
                Console.WriteLine("キャンセル");
            }

            FBD.Dispose();
            return saveDir;
          
        }
    }
}
