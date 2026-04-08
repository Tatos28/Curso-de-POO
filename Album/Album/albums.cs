namespace Album;

public class Albums
{
    private string name;
    private string[] songNames;
    
    public Albums(string name, string[] songNames)
    {
        this.name = name;
        this.songNames = songNames;
    }


    public void PlaySong(int index)
    {
        if (index < 0 || index >= songNames.Length)
        {
            throw new IndexOutOfRangeException("Índice fuera del rango del arreglo");
        }

        Console.WriteLine($"Reproduciendo: {songNames[index]}");
    }

  
    public void PlaySong(string song)
    {
        foreach (string s in songNames)
        {
            if (s == song)
            {
                Console.WriteLine($"Reproduciendo: {s}");
                return;
            }
        }

       
        throw new ArgumentOutOfRangeException("La canción no existe en el álbum");
    }
}