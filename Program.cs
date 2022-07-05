using DataStructure.All.MusicQueue;
using Implementation = DataStructure.All.LinkedList.Implementation;

public class Program
{
    public static void Main(string[] args)
    {
        // LinkedListImplementation();
        MusicQueueImplementation();
    }

    public static void LinkedListImplementation()
    {
        Implementation linkedListImplementation = new Implementation();
        
        linkedListImplementation.PushFront(4);
        linkedListImplementation.PushFront(5);
        linkedListImplementation.PushFront(6); 
        
        linkedListImplementation.PushAfter(linkedListImplementation.Head.Next.Next, 123);
        linkedListImplementation.PushAfter(linkedListImplementation.Head.Next, 1);
        linkedListImplementation.PushAfter(linkedListImplementation.Head.Next.Next, 2);
        
        linkedListImplementation.PushLast(321);
        
        linkedListImplementation.ListImplementation(linkedListImplementation.Head);
        linkedListImplementation.DeleteFirstElement();
        Console.WriteLine("\n\n");
        
        linkedListImplementation.ListImplementation(linkedListImplementation.Head);
        linkedListImplementation.DeleteLastElement();
        Console.WriteLine("\n\n");

        
        linkedListImplementation.ListImplementation(linkedListImplementation.Head);
        linkedListImplementation.DeleteMiddle(linkedListImplementation.Head.Next.Next);
        Console.WriteLine("\n\n");


        linkedListImplementation.ListImplementation(linkedListImplementation.Head);
    }

    public static void MusicQueueImplementation()
    {
        var queueMusic = new DataStructure.All.MusicQueue.Implementation();
        
        
        queueMusic.AddNewMusic("Charlie Puth", "One Call Away");
        queueMusic.AddNewMusic("Charlie Puth", "Marvin Gaye");
        
        queueMusic.ListMusicQueue();
        
        queueMusic.AddNewMusic("Anne-Marie", "2002");
        queueMusic.ListMusicQueue();
        
        queueMusic.RemoveMusic();
    }
}