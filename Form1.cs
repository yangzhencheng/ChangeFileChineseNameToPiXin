using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeFileChineseNameToPiXin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPathName_Click(object sender, EventArgs e)
        {
            listSoureName.Items.Clear();

            FolderBrowserDialog fdialog = new FolderBrowserDialog();
            fdialog.Description = "选择文件夹";

            if (fdialog.ShowDialog() == DialogResult.OK || fdialog.ShowDialog() == DialogResult.Yes)
            {
                txtPathName.Text = fdialog.SelectedPath;

                DirectoryInfo theFolder = new DirectoryInfo(txtPathName.Text);

                foreach(FileInfo nextFolder in theFolder.GetFiles())
                {
                    listSoureName.Items.Add(nextFolder.Name);
                }
            }
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdialog = new FolderBrowserDialog();
            fdialog.Description = "选择文件夹";

            if (fdialog.ShowDialog() == DialogResult.OK || fdialog.ShowDialog() == DialogResult.Yes)
            {
                string txtNewPathName = fdialog.SelectedPath;
                for (int i = 0; i < listSoureName.Items.Count; i++)
                {
                    string sourceName = listSoureName.Items[i].ToString().Replace("_", "");
                    string newName = ConvertToAllSpell(sourceName);

                    File.Copy(txtPathName.Text + "\\" + sourceName, txtNewPathName + "\\" + newName);
                }
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listSoureName.Items.Count; i++)
            {
                string strValue = listSoureName.Items[i].ToString();
                strValue = ConvertToAllSpell(strValue);
                listNewName.Items.Add(strValue);
            }
        }



        /// <summary>
        /// 汉字转全拼
        /// </summary>
        /// <param name="strChinese"></param>
        /// <returns></returns>
        public static string ConvertToAllSpell(string strChinese)
        {
            try
            {
                if (strChinese.Length != 0)
                {
                    StringBuilder fullSpell = new StringBuilder();
                    for (int i = 0; i < strChinese.Length; i++)
                    {
                        var chr = strChinese[i];
                        fullSpell.Append(GetSpell(chr));
                    }

                    return fullSpell.ToString().ToUpper();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("全拼转化出错！" + e.Message);
            }

            return string.Empty;
        }

        private static string GetSpell(char chr)
        {
            var coverchr = NPinyin.Pinyin.GetPinyin(chr);

            bool isChineses = ChineseChar.IsValidChar(coverchr[0]);
            if (isChineses)
            {
                ChineseChar chineseChar = new ChineseChar(coverchr[0]);
                foreach (string value in chineseChar.Pinyins)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        return value.Remove(value.Length - 1, 1);
                    }
                }
            }

            return coverchr;

        }

    }
}
