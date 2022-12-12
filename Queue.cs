class Queue<T>
{
  private Node<T> top = null;
  private int length = 0;

  public void Push(T value)
  {
    Node<T> node = new Node<T>(value);
    if(this.top == null)
    {
      this.top = node;
    }
    else
    {
      Node<T> lastNode = this.GetNode(this.length-1);
      lastNode.SetNext(node);
    }
    this.length++;
  }
  public T Pop()
  {
    Node<T> node = this.top;
    this.top = this.top.Next();
    this.length--;
    return node.GetValue();
  }

  public T Get(int index)
  {
    Node<T> ptr = this.GetNode(index);
    return ptr.GetValue();
  }

  public int GetLength()
  {
    return this.length;
  }

  private Node<T> GetNode(int index)
  {
    Node<T> ptr = this.top;
    while(index > 0)
    {
      ptr = ptr.Next();
      index--;
    }
    return ptr;
  }
    public void Remove(int index)
    {
        if(index == 0)
        {
            Node<T> tailPtr = this.top;
            int tailIndex = this.length - 1;
            while(tailIndex > 0)
            {
                tailPtr = tailPtr.Next();
                tailIndex--;
            }
            tailPtr.SetNext(this.top.Next());

            Node<T> ptr = this.top;
            this.top = this.top.Next();
            ptr.SetNext(null);
        }
        else
        {
            Node<T> previousPtr = this.top;
            while(index > 1)
            {
                previousPtr = previousPtr.Next();
                index--;
            }
            Node<T> ptr = previousPtr.Next();
            previousPtr.SetNext(ptr.Next());
            ptr.SetNext(null);
        }
        this.length--;
    }
        public void Insert(int index, T value)
    {
        Node<T> node = new Node<T>(value);
        if(index == 0)
        {
            Node<T> tailPtr = this.top;
            int tailIndex = this.length - 1;
            while(tailIndex > 0)
            {
                tailPtr = tailPtr.Next();
                tailIndex--;
            }
            tailPtr.SetNext(node);

            node.SetNext(this.top);
            this.top = node;
        }
        else
        {
            Node<T> previousPtr = this.top;
            while(index > 1)
            {
                previousPtr = previousPtr.Next();
                index--;
            }
            node.SetNext(previousPtr.Next());
            previousPtr.SetNext(node);
        }
        this.length++;
    }
}
