using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        using (FileStream fs = new FileStream("archivo.bin", FileMode.Create, FileAccess.Write))
        {
            byte[] data = { 72, 111, 108, 97, 77, 85, 78, 68, 79 };
            fs.Write(data, 0, data.Length);
        }

        using (FileStream fs = new FileStream("archivo.bin", FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4];
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLen;

            while ((readLen = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                Console.WriteLine(temp.GetString(buffer, 0, readLen));
            }
        }
    }
}