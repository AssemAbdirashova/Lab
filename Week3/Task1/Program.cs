using System;
using 

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Дакотти\Desktop\aaa\achieved.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("The very first line!");

            sw.Close();
            fs.Close();
            string fileName = "achieved.txt";
            string sourcePath = @"C:\Users\Дакотти\Desktop\aaa";
            string path1 = @"C:\Users\Дакотти\Desktop\bbb\western girl";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(path1, fileName);
            File.Copy(sourceFile, destFile, true);
            File.Delete(@"C:\Users\Дакотти\Desktop\aaa\achieved.txt");
        }
    }
}
