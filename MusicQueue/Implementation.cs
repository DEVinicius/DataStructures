using DataStructure.All.LinkedList;

namespace DataStructure.All.MusicQueue;

public class Implementation
{
    public MyLinkedList<Music> ActualMusic { get; set; }

    public Implementation()
    {
        ActualMusic = null;
    }

    public void AddNewMusic(string author, string musicName)
    {
        
        var newMusic = new MyLinkedList<Music>(new Music(author, musicName));

        if (ActualMusic == null)
        {
            ActualMusic = newMusic;
            return;
        }
                
        var lastMusic = GetLastMusic();
        lastMusic.Next = newMusic;

        
    }

    public void RemoveMusic()
    {
        if(ActualMusic != null)
            ActualMusic = ActualMusic.Next;
    }

    public void ListMusicQueue()
    {
        var temp = ActualMusic;
        if (temp == null) return;
        
        while (temp.Next != null)
        {
            Console.WriteLine($"Musica: {temp.Data.MusicName} - {temp.Data.Author}");
            temp = temp.Next;
        }
    }

    private MyLinkedList<Music> GetLastMusic()
    {
        var temp = ActualMusic;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        return temp;
    }
}