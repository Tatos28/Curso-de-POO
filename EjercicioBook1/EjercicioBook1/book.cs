using System;
using System.IO;

namespace EjercicioBook1;

class book
{
    public string title;
    public string author;
    public string path;
    public string[] paragraphs;
    private int nextParagraph;

    public book(string title, string author, string path)
    {
        this.title = title;
        this.author = author;
        this.path = path;
        this.paragraphs = new string[3];
        this.nextParagraph = 0;
    }

    public void AddParagraph(string paragraph)
    {
        if (nextParagraph < paragraphs.Length)
        {
            paragraphs[nextParagraph] = paragraph;
            nextParagraph++;
        }
        else
        {
            Console.WriteLine("Ya no caben más párrafos");
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("Titulo: " + title);
            sw.WriteLine("Autor: " + author);
            sw.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine(paragraphs[i]);
                sw.WriteLine();
            }
        }
    }

    public void PrintFileContent()
    {
        if (File.Exists(path))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}