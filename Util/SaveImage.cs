using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;

namespace AutoSaveImageSerial.Util
{
    internal static class SaveImage
    {
        public static async Task saveImage(string uri, string downloadPass,string saveTitle,string referer,string accept,TextBox saveImageText,List<string> log)
        {
            var client = new HttpClient();
            if (referer != "" && accept != "")
            {
                client.DefaultRequestHeaders.Add("Accept", accept);
                client.DefaultRequestHeaders.Add("Referer", referer);
            }
            var response = await client.GetAsync(uri,HttpCompletionOption.ResponseContentRead);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("download failed");
                Console.WriteLine(response.StatusCode.ToString());
                DisplayLog.displayTextLog(saveImageText, "このサイトからは画像をダウンロードできません.", log);
                MainForm.isDownloaded = false;
                return;
            };

            Stream stream = await response.Content.ReadAsStreamAsync();
            Console.WriteLine("download success");
            downloadPass = downloadPass + "\\" + saveTitle + ".jpg";
            FileStream outStream = File.Create(downloadPass);
            stream.CopyTo(outStream);
            DisplayLog.displayTextLog(saveImageText, uri + "を" + downloadPass + "に保存しました",log);
            MainForm.isDownloaded = true;
            stream.Dispose();
            outStream.Dispose();
            
        }
    }
}
