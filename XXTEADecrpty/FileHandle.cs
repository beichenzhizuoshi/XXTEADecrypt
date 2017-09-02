using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class FileHandle{
    public List<string> fileBox = new List<string>();
    public string[] strFormat = new string[5];
    public XXTEADecrypt.Form1 mForm1;
    public string outputPath;
    public string inputPath;

    public FileHandle(XXTEADecrypt.Form1 mform,string inputPath, string outputPath)
    {
        this.mForm1 = mform;
        this.outputPath = outputPath;
        this.inputPath = inputPath;
    }

	public byte[] FileRead(string path)
	{
        try
        {
            FileInfo fi = new FileInfo(path);
            long len = fi.Length;
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] buffer = new byte[len];
            fs.Read(buffer, 0, (int)len);
            fs.Flush();
            fs.Close();
            return buffer;
        }
        catch (Exception e)
        {
            mForm1.richTextBox_log.AppendText("读文件错误--->" + path + "\n");
            byte[] a = new byte[3];
            return a;
        }

        
	}
    public bool FileWrite(byte[] data, string pathAndName)
    {
        try
        {
            FileStream fs = new FileStream(pathAndName, FileMode.Create);
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }
        catch (Exception e)
        {
            mForm1.richTextBox_log.AppendText("写入失败--->" + pathAndName + "\n");
            return false;
        }

        
        return true;
    }
    public void FileToDirctory(string filePath)
    {
        FileInfo fi = new FileInfo(filePath);
        Console.WriteLine(fi.Directory.ToString());
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }
    }
	/// <summary>
    /// 获取指定目录下的所有符合条件的文件的绝对路径
    /// </summary>
    /// <param name="inputfolder">传入的目录</param>
    /// <param name="suffix">过滤条件</param>
    /// <returns>符合条件的文件的绝对路径字符串数组</returns>
    public void DirectoryToFile(string inputFolder)
	{
		DirectoryInfo TheFolder = new DirectoryInfo(inputFolder);
		string absoultPath;
        //获取当前目录的文件
        if (strFormat[0].Equals(".*"))
        {
            foreach (FileInfo nextFile in TheFolder.GetFiles())
            {
                absoultPath = nextFile.FullName;
                fileBox.Add(absoultPath);

                Console.WriteLine("获取到文件:" + absoultPath);
                mForm1.richTextBox_log.AppendText("发现文件--->" + absoultPath + "\n");
            }
        }
        else
        {
            foreach (FileInfo nextFile in TheFolder.GetFiles())
            {
                string tmp = nextFile.Name;
                for (int i = 0; strFormat[i] != null; i++)
                {
                    if (StrMatching(tmp, strFormat[i]))
                    {
                        absoultPath = nextFile.FullName;
                        fileBox.Add(absoultPath);
                        Console.WriteLine("获取到文件:" + absoultPath);
                        mForm1.richTextBox_log.AppendText("发现文件--->" + absoultPath + "\n");
                        break;
                    }  
                }        
            }
        }
        string tmp2;
		foreach(DirectoryInfo nextFolder in TheFolder.GetDirectories())
		{
            tmp2 = nextFolder.FullName;
            tmp2 = tmp2.Replace(inputPath, outputPath);
			Console.WriteLine("获取到子目录:" + nextFolder.FullName + ",待写入目录:" + tmp2);
            if (!Directory.Exists(tmp2))
            {
                Directory.CreateDirectory(tmp2);
            }
            this.DirectoryToFile(nextFolder.FullName);
		}
	}
    
    /// <summary>
    /// 将通配符中的*和?转换为正则表达式
    /// </summary>
    /// <param name="strWildcard">待转换字符串</param>
    /// <returns>转换的结果</returns>
    public string WildcardToRegex(string strWildcard)
    {
        strWildcard = strWildcard.Replace(".", @"\.");
        strWildcard = strWildcard.Replace("?", @".[1]");
        strWildcard = strWildcard.Replace("*", @".*");
       // strWildcard = "^" + strWildcard;
        return strWildcard;
    }

    public bool StrMatching(string src, string strRule)
    {
        return Regex.IsMatch(src, strRule);
    }
    
}