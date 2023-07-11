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