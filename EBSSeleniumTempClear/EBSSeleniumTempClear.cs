using System;
using System.IO;
using System.Windows.Forms;

namespace EBSSeleniumTempClear
{
    public class EBSSeleniumTempClear
    {
        string dizin = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Temp";
        int deleteid = 1;
        public void seleniumCookiedelete(Label lbl,RichTextBox rc)
        {
            string[] FolderListing = Directory.GetDirectories(dizin);
            for (int i = 0; i < FolderListing.Length; i++)
            {
                if (FolderListing[i].IndexOf("scoped") != -1)
                {
                    rc.AppendText(FolderListing[i].ToString() + "\r");
                    lbl.Text = "Delete Cookie :" + deleteid;deleteid++;
                    try
                    {
                        Directory.Delete(FolderListing[i], true);
                    }
                    catch
                    {
                        Directory.Delete(FolderListing[i], true);
                    }
                }
            }
        }
        public void TempClear(Label lbl, RichTextBox rc)
        {
            string[] FolderListing = Directory.GetDirectories(dizin);
            for (int i = 0; i < FolderListing.Length; i++)
            {
                rc.AppendText(FolderListing[i].ToString() + "\r");
                lbl.Text = "Delete Cookie :" + deleteid;deleteid++;
                try
                {
                    Directory.Delete(FolderListing[i], true);
                }
                catch
                {

                    try
                    {
                        Directory.Delete(FolderListing[i], true);
                    }
                    catch (Exception ex)
                    {
                        if (ex.HResult.ToString()== "0x80070020")
                        {
                            rc.AppendText("Dosya Kullanılıyor" + "\r");
                        }
                        
                    }
                    
                }
            }
        }
    }
}
