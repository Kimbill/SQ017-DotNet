//using System;
//using System.Collections;
//using System.Collections.Generic;

//class Program3
//{
//    static void Main()
//    {
//        Linear Array
//        int[] linearArray = new int[5];
//        linearArray[0] = 10;
//        Console.WriteLine("Linear Array:");
//        Console.WriteLine(linearArray[0]); // Outputs: 10

//        Multi - Dimensional Array
//        int[,] multiDimArray = new int[3, 3];
//        multiDimArray[1, 1] = 25;
//        Console.WriteLine("Multi-Dimensional Array:");
//        Console.WriteLine(multiDimArray[1, 1]); // Outputs: 25

//        Jagged Array
//        int[][] jaggedArray = new int[3][];
//        jaggedArray[0] = new int[] { 1, 2, 3 };
//        jaggedArray[1] = new int[] { 4, 5 };
//        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
//        Console.WriteLine("Jagged Array:");
//        Console.WriteLine(jaggedArray[0][1]); // Outputs: 2

//        ArrayList
//       ArrayList arrayList = new ArrayList();
//        arrayList.Add(10);
//        arrayList.Add("Hello");
//        Console.WriteLine("ArrayList:");
//        Console.WriteLine(arrayList[1]); // Outputs: Hello

//        Generics
//        List<int> intList = new List<int>();
//        intList.Add(42);
//        Console.WriteLine("Generics List:");
//        Console.WriteLine(intList[0]); // Outputs: 42

//        List
//        List<string> stringList = new List<string>();
//        stringList.Add("Apple");
//        stringList.Add("Banana");
//        Console.WriteLine("List:");
//        Console.WriteLine(stringList[1]); // Outputs: Banana

//        Stacks(LIFO)
//        Stack<int> stack = new Stack<int>();
//        stack.Push(1);
//        stack.Push(2);
//        int poppedElement = stack.Pop();
//        Console.WriteLine("Stack:");
//        Console.WriteLine(poppedElement); // Outputs: 2

//        Queues(FIFO)
//        Queue<string> queue = new Queue<string>();
//        queue.Enqueue("First");
//        queue.Enqueue("Second");
//        string dequeuedElement = queue.Dequeue();
//        Console.WriteLine("Queue:");
//        Console.WriteLine(dequeuedElement); // Outputs: First

//        Hashtable
//       Hashtable hashtable = new Hashtable();
//        hashtable.Add("key1", "value1");
//        hashtable.Add("key2", "value2");
//        Console.WriteLine("Hashtable:");
//        Console.WriteLine(hashtable["key1"]); // Outputs: value1

//        Dictionary
//        Dictionary<string, int> dictionary = new Dictionary<string, int>();
//        dictionary.Add("one", 1);
//        dictionary.Add("two", 2);
//        Console.WriteLine("Dictionary:");
//        Console.WriteLine(dictionary["one"]); // Outputs: 1

//        Tuple
//       var tuple = Tuple.Create(1, "hello", 3);
//        Console.WriteLine("Tuple:");
//        Console.WriteLine(tuple.Item1); // Outputs: 1
//        Console.WriteLine(tuple.Item2); // Outputs: hello
//        Console.WriteLine(tuple.Item3);

//        Indexer
//       MyClass myObject = new MyClass();
//        myObject[0] = "Value at index 0";
//        Console.WriteLine("Indexer:");
//        Console.WriteLine(myObject[0]); // Outputs: Value at index 0

//        Delegates and Lambdas
//       MathOperation add = (x, y) => x + y;
//        Console.WriteLine("Delegate and Lambda:");
//        Console.WriteLine(add(5, 3)); // Outputs: 8

//        Events
//       Publisher publisher = new Publisher();
//        publisher.MyEvent += (sender, e) => Console.WriteLine("Event raised!");
//        publisher.RaiseEvent();
//    }
//}

//class MyClass
//{
//    private string[] data = new string[5];

//    public string this[int index]
//    {
//        get => data[index];
//        set => data[index] = value;
//    }
//}

//delegate int MathOperation(int x, int y);

//class Publisher
//{
//    public event EventHandler MyEvent;

//    public void RaiseEvent()
//    {
//        MyEvent?.Invoke(this, EventArgs.Empty);
//    }
//}
