public class MyShitLinkedList
{
    private int[] _linkedList;// 算法题不考虑并发
    // {
    //     get
    //     {
    //         lock (this)
    //         {
    //             return linkedlist;
    //         }
    //     }
    //     set
    //     {
    //         linkedlist = value;
    //     }

    // }
    public MyShitLinkedList()
    {
        _linkedList = new int[] { };
    }

    public int Get(int index)
    {
        if (index < 0 || index > _linkedList.Length - 1)
        {
            return -1;
        }
        return _linkedList[index];
    }

    public void AddAtHead(int val)
    {
        var newList = new int[_linkedList.Length + 1];
        newList[0] = val;

        for (int i = 0; i < _linkedList.Length; i++)
        {
            newList[i + 1] = _linkedList[i];
        }
        _linkedList = newList;
    }

    public void AddAtTail(int val)
    {
        var newList = new int[_linkedList.Length + 1];
        newList[_linkedList.Length] = val;

        for (int i = 0; i < _linkedList.Length; i++)
        {
            newList[i] = _linkedList[i];
        }
        _linkedList = newList;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > _linkedList.Length)
        {
            return;
        }
        var newList = new int[_linkedList.Length + 1];
        newList[index] = val;

        for (int i = 0; i < _linkedList.Length; i++)
        {
            if (i < index)
            {
                newList[i] = _linkedList[i];
            }
            else
            {
                newList[i + 1] = _linkedList[i];
            }
        }
        _linkedList = newList;
    }

    public void DeleteAtIndex(int index)
    {
        if (index > _linkedList.Length - 1)
        {
            return;
        }
        var newList = new int[_linkedList.Length - 1];
        for (int i = 0; i < _linkedList.Length; i++)
        {
            if (i < index)
            {
                newList[i] = _linkedList[i];
            }
            else if (i > index)
            {
                newList[i - 1] = _linkedList[i];
            }
        }
        _linkedList = newList;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */

// Wrong answer - 错误解
public class MyLinkedList
{
    private int size;
    private ListNode linkedList;
    public MyLinkedList()
    {
        size = 0;
        linkedList = new ListNode(0);
    }

    public int Get(int index)
    {
        if (index > size - 1 || index < 0)
        {
            return -1;
        }
        ListNode current;
        current = linkedList.next;
        if (index == 0)
        {
            return current.val;
        }
        for (int i = 1; i < size; i++)
        {
            current = current.next;
            if (i == index)
            {
                return current.val;
            }
        }
        return -1;
    }

    public void AddAtHead(int val)
    {
        AddAtIndex(0, val);
    }

    public void AddAtTail(int val)
    {
        AddAtIndex(size, val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > size || index < 0)
        {
            return;
        }
        var newNode = new ListNode(val);
        ListNode current;
        current = linkedList.next;
        if (index == 0)
        {
            newNode.next = current;
            linkedList.next = newNode;
            size++;
            return;
        }
        for (int i = 1; i < size; i++)
        {
            current = current.next;
            if (i == index - 1)
            {
                var temp = current.next;
                current.next = newNode;
                newNode.next = temp;
                size++;
                return;
            }
        }
    }

    public void DeleteAtIndex(int index)
    {
        if (index > size - 1 || index < 0)
        {
            return;
        }
        ListNode current;
        current = linkedList.next;
        if (index == 0)
        {
            var temp = current.next?.next;
            linkedList.next = temp;
            size--;
            return;
        }
        for (int i = 1; i < size; i++)
        {
            current = current.next;
            if (i == index - 1)
            {
                var temp = current.next?.next;
                current.next = temp;
                size--;
                return;
            }
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int value)
    {
        val = value;
    }
}