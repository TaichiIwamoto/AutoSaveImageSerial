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
        private string[] uriCache = new string[2];
        public List<string> log = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            this.ModeSelectComboBox.Text = this.ModeSelectComboBox.Items[0].ToString();//モード選択初期化=ダウンロード
            this.SelectSiteDropDown.Text = this.SelectSiteDropDown.Items[2].ToString();//サイト選択初期化=その他
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void SaveDirText_TextChanged(object sender, EventArgs e)
        {

        }

        //ディレクトリ選択
        private void SaveDirButton_Click(object sender, EventArgs e)
        {
            saveDirPass = Directory.getSaveDirectory();
            SaveDirText.Text = saveDirPass;
        }

        private void SaveTitleText_TextChanged(object sender, EventArgs e)
        {
        }

        //サイト選択
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

        //連番決定処理
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

        //連番リセット
        private void ResetSaveNum_Click(object sender, EventArgs e)
        {
            saveNum = 0;
            this.SaveNumberText_TextChanged(sender, e);

        }

        private void SaveImageText_TextChanged(object sender, EventArgs e)
        {
        }

        //画像保存
        private async void SaveImageText_DragDrop(object sender, DragEventArgs e)
        {
            bool nullError = false; //保存先dir又はタイトル未入力かどうか
            string uri = e.Data.GetData(DataFormats.Text).ToString();//画像のURI
            string saveTitle = SaveTitleText.Text + SaveNumberText.Text;//保存タイトル(連番付き)
            //重複判定
            {
                if (saveNum == 0)
                {
                    uriCache[0] = uri;
                }
                else if (saveNum == 1)
                {
                    uriCache[1] = uri;
                    if (uriCache[0] == uriCache[1])
                    {

                        DialogResult result = MessageBox.Show(this, "前回保存した画像と同じですが続行しますか?", "重複通知", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }

                }
                else
                {
                    uriCache[0] = uriCache[1];
                    uriCache[1] = uri;
                    if (uriCache[0] == uriCache[1])
                    {

                        DialogResult result = MessageBox.Show(this, "前回保存した画像と同じですが続行しますか?", "重複通知", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }
            ////
            //画像保存
            {
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
                await SaveImage.saveImage(uri, saveDirPass, saveTitle, referer, accept, this.SaveImageText, log);
                saveNum += 1;
                this.SaveNumberText_TextChanged(sender, e);
            }

        }

        private void SaveImageText_DragEnter(object sender, DragEventArgs e)
        {
            if (this.ModeSelectComboBox.Text == "ダウンロード")
            {
                if (e.Data.GetDataPresent("UniformResourceLocator") || e.Data.GetDataPresent("UniformResourceLocatorW"))//URIの場合
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        //ログ初期化
        private void LogResetButton_Click(object sender, EventArgs e)
        {
            this.SaveImageText.Text = "";

        }

        private void ModeSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.ModeSelectComboBox.Text == "キャプチャ")
            {

            }

        }
    }
}
