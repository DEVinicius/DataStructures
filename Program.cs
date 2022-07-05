using DataStructure.All.LinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedListImplementation();
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
}