namespace DataStructure.All.LinkedList;

public class Implementation
{
    public MyLinkedList<int> Head { get; set; }

    public Implementation()
    {
        Head = null;
    }

    public void PushFront(int newData)
    {
        MyLinkedList<int> newHead = new MyLinkedList<int>(newData);
        newHead.Next = Head;

        Head = newHead;
    }

    public void PushAfter(MyLinkedList<int> preventNode, int newData)
    {
        MyLinkedList<int> newNode = new MyLinkedList<int>(newData);

        newNode.Next = preventNode.Next;
        preventNode.Next = newNode;
    }

    public void PushLast(int newData)
    {
        MyLinkedList<int> newNode = new MyLinkedList<int>(newData);

        var lastData = FindLastElement(Head);

        lastData.Next = newNode;
    }

    private MyLinkedList<int> FindLastElement(MyLinkedList<int> data)
    {
        if (data.Next != null)
        {
            return FindLastElement(data.Next);
        }

        return data;
    }

    public void DeleteFirstElement()
    {
        if (Head != null)
            Head = Head.Next;
    }

    public void DeleteLastElement()
    {
        var tempData = Head;
        while (tempData.Next.Next != null)
        {
            tempData = tempData.Next;
        }

        tempData.Next = null;
    }

    public void DeleteMiddle(MyLinkedList<int> beforeElement)
    {
        beforeElement.Next = beforeElement.Next.Next;
    }

    public void ListImplementation(MyLinkedList<int> LastPosition)
    {
        Console.WriteLine(LastPosition.Data);
        if (LastPosition.Next != null)
        {
            ListImplementation(LastPosition.Next);
        }
    }
}