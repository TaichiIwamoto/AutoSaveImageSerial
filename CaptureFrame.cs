using AutoSaveImageSerial.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaveImageSerial
{
    public partial class CaptureFrame : Form
    {
        private bool capturing;
        private bool isResizing = false;
        private Point mouseDownLocation;
        private MainForm mainForm;
        public CaptureFrame(MainForm mainForm)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.AllowTransparency = true;
            this.mainForm = mainForm;

        }

        private void CaptureFrame_FormClosed(object sender, FormClosedEventArgs e)
        {

            MainForm.capturing = false;
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.IsTopMost = true;
            Console.WriteLine(MainForm.capturing);
        }

        //キャプチャ処理
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            string saveTitle = mainForm.SaveTitleText.Text;
            string dirPath = mainForm.SaveDirText.Text;
            string tmpNum = "";

            int saveNum = MainForm.saveNum;
            if (saveNum < 10)
            {
                tmpNum = "0" + saveNum.ToString();
            }
            else
            {
                tmpNum = saveNum.ToString();
            }
            Console.WriteLine("saveTitle=", saveTitle);
            Console.WriteLine("dirPath=", dirPath);

            if (saveTitle.Equals("") || dirPath.Equals(""))
            {
                DisplayLog.displayTextLog(mainForm.SaveImageText, "保存先ディレクトリと保存タイトルを入力してください", MainForm.log);
                return;
            }
            Rectangle captureRect = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Visible = false;//キャプチャする際にコントロールが映るの防ぐ

            using (Bitmap bitmap = new Bitmap(captureRect.Width, captureRect.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(captureRect.Location, Point.Empty, captureRect.Size);
                }

                bitmap.Save(dirPath+"/"+ saveTitle+tmpNum+".png", ImageFormat.Png);
            }


            //連番変化
            MainForm.saveNum += 1;
            saveNum = MainForm.saveNum;
            if (saveNum < 10)
            {
                tmpNum = "0" + saveNum.ToString();
            }
            else
            {
                tmpNum = saveNum.ToString();
            }
            mainForm.SaveNumberText.Text = tmpNum;
            ////
           
            this.Visible = true;

        }
    }
}
