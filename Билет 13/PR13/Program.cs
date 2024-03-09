using System;

class Stack
{
    private int[] array;
    private int top;
    private int capacity;

    public Stack(int size)
    {
        capacity = size;
        array = new int[capacity];
        top = -1;
    }

    public void Push(int item)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Стек переполнен. Невозможно добавить элемент.");
            return;
        }

        array[++top] = item;
        Console.WriteLine("Добавлен элемент: {0}", item);
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Стек пуст. Невозможно извлечь элемент.");
            return -1;
        }

        int item = array[top--];
        Console.WriteLine("Извлечен элемент: {0}", item);
        return item;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Стек пуст.");
            return -1;
        }

        return array[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Стек пуст.");
            return;
        }

        Console.WriteLine("Элементы стека:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        stack.PrintStack();

        stack.Push(6);

        stack.Pop();
        stack.Pop();

        stack.PrintStack();

        Console.WriteLine("Верхний элемент стека: {0}", stack.Peek());

        stack.Pop();
        stack.Pop();
        stack.Pop();

        stack.PrintStack();
    }
}
