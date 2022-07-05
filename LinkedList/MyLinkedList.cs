namespace DataStructure.All.LinkedList;

public class MyLinkedList<T>
{
    public T Data { get; set; }
    public MyLinkedList<T> Next { get; set; }

    public MyLinkedList(T data)
    {
        Data = data;
        Next = null;
    }
}