using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaveImageSerial.Util
{
    internal static class DisplayLog
    {
        static public void displayTextLog(TextBox saveImageText,string logStr, List<string> log)
        {
            log.Add(logStr);

            foreach(string line in saveImageText.Lines)
            {
                log.Add(line);
            }
            saveImageText.Text = "";
            foreach (string logItem in log)
            {
                saveImageText.Text += logItem + Environment.NewLine;
                Console.WriteLine(logItem);
            }
            log.Clear();


            
        }
    }
}
