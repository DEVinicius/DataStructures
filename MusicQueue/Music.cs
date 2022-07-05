namespace DataStructure.All.MusicQueue;

public class Music
{
    public string Author { get; private set; }
    public string MusicName { get; private set; }

    public Music(string author, string musicName)
    {
        Author = author;
        MusicName = musicName;
    }
}