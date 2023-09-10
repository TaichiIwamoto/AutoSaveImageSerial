using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoSaveImageSerial.Util;
using static System.Net.WebRequestMethods;

namespace AutoSaveImageSerial
{
    public partial class MainForm : Form

    {
        private string referer;
        private string accept;
        private string saveDirPass;
        private int saveNum = 0;
        public List<string> log = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveDirText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveDirButton_Click(object sender, EventArgs e)
        {
            saveDirPass = Directory.getSaveDirectory();
            SaveDirText.Text = saveDirPass;
        }

        private void SaveTitleText_TextChanged(object sender, EventArgs e)
        {
        }

        private void SelectSiteDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectNum = this.SelectSiteDropDown.SelectedIndex;
            referer = this.SelectSiteDropDown.Items[selectNum].ToString();
            if (referer == "Pixiv")
            {
                accept = "*/*";
                referer = "https://www.pixiv.net/";
            }
            else if (referer == "Fanbox")
            {
                accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                referer = "https://www.fanbox.cc/";
            }
            else if (referer == "Fantia")
            {
                accept = "";
                referer = "";
            }
            else
            {
                accept = "";
                referer = "";
            }

        }

        private void SaveNumberText_TextChanged(object sender, EventArgs e)
        {
            string tmpNum = "";
            if (saveNum < 10)
            {
                tmpNum = "0" + saveNum.ToString();
            }
            else
            {
                tmpNum = saveNum.ToString();
            }
            SaveNumberText.Text = tmpNum;
        }

        private void ResetSaveNum_Click(object sender, EventArgs e)
        {
            saveNum = 0;
            this.SaveNumberText_TextChanged(sender, e);

        }

        private void SaveImageText_TextChanged(object sender, EventArgs e)
        {
        }

        private async void SaveImageText_DragDrop(object sender, DragEventArgs e)
        {
            bool nullError = false;
            string uri = e.Data.GetData(DataFormats.Text).ToString();
            Console.WriteLine(uri);
            Console.WriteLine(saveDirPass);
            string saveTitle = SaveTitleText.Text + SaveNumberText.Text;
            if (saveDirPass == null)
            {
                DisplayLog.displayTextLog(this.SaveImageText, "保存先を選択してください", log);
                nullError = true;
            }
            if (SaveTitleText.Text == "")
            {
                DisplayLog.displayTextLog(this.SaveImageText, "タイトルを入力してください.", log);
                nullError = true;
            }
            if (nullError == true)
            {
                return;
            }
            await SaveImage.saveImage(uri, saveDirPass, saveTitle, referer, accept,this.SaveImageText,log);
            saveNum += 1;
            this.SaveNumberText_TextChanged(sender, e);

        }

        private void SaveImageText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("UniformResourceLocator") || e.Data.GetDataPresent("UniformResourceLocatorW"))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void LogResetButton_Click(object sender, EventArgs e)
        {
            this.SaveImageText.Text = "";

        }
    }
}
