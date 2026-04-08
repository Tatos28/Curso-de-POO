using Album;


class Program
{
    static void Main(string[] args)
    {
        string[] songs = { "Song A", "Song B", "Song C" };
        Albums album = new Albums("Mi Álbum", songs);

        try
        {
            album.PlaySong("Song B");   
            album.PlaySong(1);          

            album.PlaySong("Song X");  
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            album.PlaySong(10);       
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}