using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace XXTEADecrypt
{
    public partial class Form1 : Form
    {
        
        public Form1 mForm1;
        public string  inputPath, outputPath;
        public byte[] XXTEA_sign, XXTEA_KEY;
        public FileHandle mFileHandle ;
        public XXTEAHelp mXXTEAHelp = new XXTEAHelp();
        public Form1()
        {
            mForm1 = this;
            mFileHandle = new FileHandle(mForm1, inputPath, outputPath);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts1 = new TimeSpan(DateTime.Now.Ticks);
             
                    
            mFileHandle.fileBox.Clear();
            richTextBox_log.Clear();
            if (!CheckState()) return;

            if (!Directory.Exists(outputPath))
            {
                MessageBox.Show("您的输出目录并不是有效路径!");
                return;
            }
            Console.WriteLine("输出目录:" + outputPath);

            if (Directory.Exists(inputPath))
            {
                Console.WriteLine("输入目录:" + inputPath);
                if (!CheckFormat()) return;
                this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(解密中...勿操作)";
                mFileHandle.DirectoryToFile(inputPath);
            }
            else if (File.Exists(inputPath))
            {
                mFileHandle.FileToDirctory(inputPath); 
                Console.WriteLine("输入路径是文件");
                this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(解密中...勿操作)";
                FileInfo fs = new FileInfo(inputPath);
                if (DecryptFile(inputPath, inputPath.Replace(fs.Directory.ToString(), outputPath)))
                {
                    richTextBox_log.AppendText("解密完成--->" + inputPath.Replace(fs.Directory.ToString(), outputPath) + "\n");
                }
                else
                {
                    richTextBox_log.AppendText("--->解密失败,该文件不是加密文件或写入文件失败!\n");
                }
                richTextBox_log.AppendText("--->解密已全部完成,如有任何疑问或建议请联系作者,支持作者请查看\"关于\"\n");
                this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(解密完成)";
                return;
            }
            else {
                MessageBox.Show("您的输入路径不是有效的目录或文件!");
            }
            //此处开始调用解密函数
            
            int i = 0;
            foreach (string mInputPath in mFileHandle.fileBox)
            {
                Console.WriteLine("-->输出路径:" + mInputPath.Replace(inputPath, outputPath));
                if (DecryptFile(mInputPath, mInputPath.Replace(inputPath, outputPath)))
                {
                    richTextBox_log.AppendText("解密完成--->" + mInputPath.Replace(inputPath, outputPath) + "\n");
                }
                else
                {
                    i++;
                }
            }
            if (i == 0)
            {
                richTextBox_log.AppendText("全部完成--->总共解密有" + mFileHandle.fileBox.Count + "个文件!\n");

            }
            else {
                richTextBox_log.AppendText("全部完成--->总共解密有" + mFileHandle.fileBox.Count + "个文件,其中有" + i + "个文件没有加密或解密失败!\n");
            }
            TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan ts = ts2.Subtract(ts1).Duration(); //时间差的绝对值 
            string spanTime = ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分" + ts.Seconds.ToString() + "秒"; //以X小时X分X秒的格式现实执行时间 

            richTextBox_log.AppendText("--->解密已全部完成共耗时:"+ spanTime + ",如有任何疑问或建议请联系作者,支持作者请查看\"关于\"\n");
            this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(解密完成)";
            

        }

        private void textBox_DeDragDrop(object sender, DragEventArgs e)
        {
            textBox_inputPath.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void textBox_DeDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void textBox_enDragDrop(object sender, DragEventArgs e)
        {
            textBox_outputPath.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void textBox_enDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string str = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                if (Directory.Exists(str))
                {
                    e.Effect = DragDropEffects.Link;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (!fbd.SelectedPath.Equals(""))
            {
                textBox_outputPath.Text = fbd.SelectedPath;
            }

        }

        private void button_inputCheck_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (!fbd.SelectedPath.Equals(""))
            {
                textBox_inputPath.Text = fbd.SelectedPath;
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            TimeSpan ts1 = new TimeSpan(DateTime.Now.Ticks);
            
           
            mFileHandle.fileBox.Clear();
            richTextBox_log.Clear();
            if (!CheckState()) return;

            if (!Directory.Exists(outputPath))
            {
                MessageBox.Show("您的输出目录并不是有效路径!");
                return;
            }
            Console.WriteLine("输出目录:" + outputPath);

            if (Directory.Exists(inputPath))
            {
                Console.WriteLine("输入目录:" + inputPath);
                if (!CheckFormat()) return;
                this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(加密中...勿操作)";
                mFileHandle.DirectoryToFile(inputPath);
            }
            else if (File.Exists(inputPath))
            {
                mFileHandle.FileToDirctory(inputPath);
                Console.WriteLine("输入路径是文件");
                this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(加密中...勿操作)";
                FileInfo fs = new FileInfo(inputPath);
                if (EncryptFile(inputPath, inputPath.Replace(fs.Directory.ToString(), outputPath)))
                {
                    richTextBox_log.AppendText("加密完成--->" + inputPath.Replace(fs.Directory.ToString(), outputPath) + "\n");
                }
                else
                {
                    richTextBox_log.AppendText("--->加密失败,可能写入文件失败!\n");
                }
                richTextBox_log.AppendText("--->加密已全部完成,如有任何疑问或建议请联系作者,支持作者请查看\"关于\"!\n");
                this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(加密完成)";
                return;
            }
            else
            {
                MessageBox.Show("您的输入路径不是有效的目录或文件!");
            }
            //此处开始调用加密函数
            
            int i = 0;
            foreach (string mInputPath in mFileHandle.fileBox)
            {
                Console.WriteLine("-->输出路径:" + mInputPath.Replace(inputPath, outputPath));
                if (EncryptFile(mInputPath, mInputPath.Replace(inputPath, outputPath)))
                {
                    richTextBox_log.AppendText("加密完成--->" + mInputPath.Replace(inputPath, outputPath) + "\n");
                }
                else
                {
                    i++;
                }
            }
            if (i == 0)
            {
                richTextBox_log.AppendText("全部完成--->总共加密有" + mFileHandle.fileBox.Count + "个文件!\n");
            }
            else {
                richTextBox_log.AppendText("全部完成--->总共加密有" + mFileHandle.fileBox.Count + "个文件,其中有" + i + "个文件加密失败!\n");
            }
            TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan ts = ts2.Subtract(ts1).Duration(); //时间差的绝对值 
            string spanTime = ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分" + ts.Seconds.ToString() + "秒"; //以X小时X分X秒的格式现实执行时间 
            richTextBox_log.AppendText("--->加密已全部完成共耗时" + spanTime + ",如有任何疑问或建议请联系作者,支持作者请查看\"关于\"!\n");
            this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587(加密完成)";
            
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "lua文件(*.lua)|*.lua|luac文件(*.luac)|*.luac|所有文件(*.*)|*.*";
            ofd.ShowDialog();
            if (!ofd.FileName.Equals(""))
            {
                textBox_inputPath.Text = ofd.FileName;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "---欢迎使用该工具，初次使用请查看帮助，有任何疑问和建议可以联系作者，申明本工具完全免费使用，请不要用于商业用途！任何非法和损害他人利益行为与作者无关!\n";
            richTextBox_log.AppendText(str);
            
        }
        private bool DecryptFile(string inputFile, string outputFile)
        {
            byte[] srcData = mFileHandle.FileRead(inputFile);  
            byte[] tmp = new byte[XXTEA_sign.Length];
            if (srcData.Length < XXTEA_sign.Length) return false;
            Array.Copy(srcData, tmp, XXTEA_sign.Length);
            for (int i = 0; i < XXTEA_sign.Length; i++)
            {
                if (tmp[i] != XXTEA_sign[i])
                {
                    richTextBox_log.AppendText("签名错误--->" + inputFile + "\n");
                    return false;
                }
            }
            //此处需要去掉文件头的签名值并重新计算数据长度
            uint ret_length;
            int len = srcData.Length - XXTEA_sign.Length;
            byte[] data = new byte[len];
            Buffer.BlockCopy(srcData, XXTEA_sign.Length, data, 0, len);
            byte[] data2 = mXXTEAHelp.xxtea_decrypt(data, (uint)len, XXTEA_KEY, (uint)XXTEA_KEY.Length, out ret_length);
            if (mFileHandle.FileWrite(data2, outputFile)) return true;
            return false; 
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
            
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private bool EncryptFile(string inputFile, string outputFile)
        {
            byte[] srcData = mFileHandle.FileRead(inputFile);
            uint ret_length;
            byte[] data = mXXTEAHelp.xxtea_encrypt(srcData, (uint)srcData.Length, XXTEA_KEY, (uint)XXTEA_KEY.Length, out ret_length);
            byte[] data2 = new byte[data.Length + XXTEA_sign.Length];
            Buffer.BlockCopy(XXTEA_sign, 0, data2, 0, XXTEA_sign.Length);
            Buffer.BlockCopy(data, 0, data2, XXTEA_sign.Length, data.Length);
            if (mFileHandle.FileWrite(data2, outputFile)) return true;
            return false;
        }

        private void richTextBox_log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_log.SelectionStart = richTextBox_log.Text.Length;
            richTextBox_log.ScrollToCaret();
        }

        /// <summary>
        /// 检查输入的内容不为空
        /// </summary>
        /// <returns>检查结果</returns>
        public bool CheckState()
        {
            if (textBox_sign.Text.Equals(""))
            {
                MessageBox.Show("签名值为空,请输入签名值!");
                return false;
            }
            XXTEA_sign = Encoding.ASCII.GetBytes(textBox_sign.Text);
            if (textBox_KEY.Text.Equals(""))
            {
                MessageBox.Show("解密KEY为空,请重新输入!");
                return false;
            }
            XXTEA_KEY = Encoding.ASCII.GetBytes(textBox_KEY.Text);
            if (textBox_inputPath.Text.Equals(""))
            {
                MessageBox.Show("输入路径为空,请重新输入!");
                return false;
            }
            inputPath = textBox_inputPath.Text;
            mFileHandle.inputPath = inputPath;
            if (textBox_outputPath.Text.Equals(""))
            {
                MessageBox.Show("输出路径为空,请重新输入!");
                return false;
            }
            outputPath = textBox_outputPath.Text;
            mFileHandle.outputPath = outputPath;         
            return true;
        }
        /// <summary>
        /// 检查选择解密的格式是否正确
        /// </summary>
        /// <returns>返回结果</returns>
        public bool CheckFormat()
        {
            if (!textBox_custom.Text.Equals("") || checkBox_lua.Checked || checkBox_luac.Checked || checkBox_zip.Checked || checkBox_png.Checked || checkBox_full.Checked)
            {
                if (checkBox_full.Checked)
                {
                    if (!textBox_custom.Text.Equals("") || checkBox_lua.Checked || checkBox_luac.Checked || checkBox_zip.Checked || checkBox_png.Checked)
                    {
                        MessageBox.Show("您选择要解密的文件格式存在重复项,请检查后重新选择!");
                        return false;
                    }
                    else
                    {
                        mFileHandle.strFormat[0] = "*";
                        return true;
                    }
                }
                else if (!textBox_custom.Text.Equals(""))
                {
                    if (textBox_custom.Text.Equals("*.lua") || textBox_custom.Text.Equals("*.luac") || textBox_custom.Text.Equals("*.zip") || textBox_custom.Text.Equals("*.png"))
                    {
                        MessageBox.Show("您输入的自定义格式与勾选项存在重复,请检查后重新输入!");
                        return false;
                    }
                }
                int i = 0;
                if (checkBox_luac.Checked)
                {
                    mFileHandle.strFormat[i] = mFileHandle.WildcardToRegex("*.luac$");
                    i++;
                }
                if (checkBox_lua.Checked)
                {
                    mFileHandle.strFormat[i] = mFileHandle.WildcardToRegex("*.lua$");
                    i++;
                }
                if (checkBox_zip.Checked)
                {
                    mFileHandle.strFormat[i] = mFileHandle.WildcardToRegex("*.zip$");
                    i++;
                }
                if (checkBox_png.Checked)
                {
                    mFileHandle.strFormat[i] = mFileHandle.WildcardToRegex("*.png$");
                    i++;
                }
                if (!textBox_custom.Text.Equals(""))
                {
                    mFileHandle.strFormat[i] = mFileHandle.WildcardToRegex("^" + textBox_custom.Text);
                }
            }
            else
            {
                MessageBox.Show("请选择要解密的文件类型!");
                return false;
            }
            return true;
        }
      
    }
}
