//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace DataStructureExamples
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Arrays
//            //int[] linearArray = { 1, 2, 3, 4, 5 };
//            //int[,] multiDimensionalArray = 
//            //    { 
//            //    { 1, 2 }, 
//            //    { 3, 4 }, 
//            //    { 5, 6 } };
//            int[][] jaggedArray = new int[3][];
//            jaggedArray[0] = new int[] { 1, 2, 3 };
//            jaggedArray[1] = new int[] { 4, 5 };
//            jaggedArray[2] = new int[] { 6, 7, 8 };

//            //Console.WriteLine("Linear Array:");
//            //foreach (var item in linearArray)
//            //{
//            //    Console.Write(item + " ");
//            //}
//            //Console.WriteLine("\n");

//            //Console.WriteLine("Multi-Dimensional Array:");
//            //for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
//            //    {
//            //        Console.Write(multiDimensionalArray[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine();

//            Console.WriteLine("Jagged Array:");
//            for (int i = 0; i < jaggedArray.Length; i++)
//            {
//                foreach (var item in jaggedArray[i])
//                {
//                    Console.Write(item + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            // ArrayList (Avoid in favor of generic collections)
//            ArrayList arrayList = new ArrayList();
//            arrayList.Add(10);
//            arrayList.Add("Hello");
//            arrayList.Add(true);

//            Console.WriteLine(arrayList[1]);
//            //foreach (var item in arrayList)
//            //{
//            //    Console.Write(item + " ");
//            //}
//            Console.WriteLine("\n");

//            //        // Generics
//            //        List<int> genericList = new List<int>();
//            //        genericList.Add(20);
//            //        genericList.Add(30);

//            //        Console.WriteLine("Generic List:");
//            //        foreach (var item in genericList)
//            //        {
//            //            Console.Write(item + " ");
//            //        }
//            //        Console.WriteLine("\n");

//            //        // List
//            //        List<string> stringList = new List<string>();
//            //        stringList.Add("Apple");
//            //        stringList.Add("Banana");

//            //        Console.WriteLine("String List:");
//            //        foreach (var item in stringList)
//            //        {
//            //            Console.Write(item + " ");
//            //        }
//            //        Console.WriteLine("\n");

//            //        // Stacks
//            Stack<int> stack = new Stack<int>();
//            stack.Push(1);
//            stack.Push(2);
//            stack.Push(3);

//            Console.WriteLine("Stack:");
//            while (stack.Count > 0)
//            {
//                Console.Write(stack.Pop() + " ");
//            }
//            Console.WriteLine("\n");

//            //        // Queues
//            Queue<string> queue = new Queue<string>();
//            queue.Enqueue("One");
//            queue.Enqueue("Two");
//            queue.Enqueue("Three");

//            Console.WriteLine("Queue:");
//            while (queue.Count > 0)
//            {
//                Console.Write(queue.Dequeue() + " ");
//            }
//            Console.WriteLine("\n");

//            //        // Hashtable (Avoid in favor of Dictionary)
//            //        Hashtable hashtable = new Hashtable();
//            //        hashtable.Add("Key1", "Value1");
//            //        hashtable.Add("Key2", "Value2");

//            //        Console.WriteLine("Hashtable:");
//            //        foreach (DictionaryEntry entry in hashtable)
//            //        {
//            //            Console.WriteLine(entry.Key + ": " + entry.Value);
//            //        }
//            //        Console.WriteLine();

//            //        // Dictionary
//            //        Dictionary<string, int> dictionary = new Dictionary<string, int>();
//            //        dictionary.Add("One", 1);
//            //        dictionary.Add("Two", 2);

//            //        Console.WriteLine("Dictionary:");
//            //        foreach (var kvp in dictionary)
//            //        {
//            //            Console.WriteLine(kvp.Key + ": " + kvp.Value);
//            //        }
//            //        Console.WriteLine();

//            //        // Tuple
//            //        Tuple<int, string> tuple = new Tuple<int, string>(42, "Hello");

//            //        Console.WriteLine("Tuple:");
//            //        Console.WriteLine(tuple.Item1 + ": " + tuple.Item2);
//            //        Console.WriteLine();

//            //        // Indexer
//            //        SampleCollection collection = new SampleCollection();
//            //        collection[0] = "First Item";
//            //        collection[1] = "Second Item";

//            //        Console.WriteLine("Indexer:");
//            //        Console.WriteLine(collection[0]);
//            //        Console.WriteLine(collection[1]);
//            //        Console.WriteLine();

//            //        // Delegates (Lambda - syntactic sugar)
//            //        Func<int, int, int> add = (a, b) => a + b;

//            //        Console.WriteLine("Delegate (Lambda):");
//            //        Console.WriteLine("Add: " + add(5, 3));
//            //        Console.WriteLine();

//            //        // Events
//            //        MyEventPublisher eventPublisher = new MyEventPublisher();
//            //        MyEventListener eventListener = new MyEventListener();
//            //        eventPublisher.MyEvent += eventListener.HandleEvent;

//            //        Console.WriteLine("Event:");
//            //        eventPublisher.DoSomething(); // This will trigger the event
//            //    }
//            //}

//            //// Sample class to demonstrate Indexer
//            //class SampleCollection
//            //{
//            //    private string[] items = new string[10];
//            //    public string this[int index]
//            //    {
//            //        get => items[index];
//            //        set => items[index] = value;
//            //    }
//            //}

//            //// Sample class to demonstrate Events
//            //class MyEventPublisher
//            //{
//            //    public event EventHandler MyEvent;

//            //    public void DoSomething()
//            //    {
//            //        Console.WriteLine("Doing something...");
//            //        OnMyEvent();
//            //    }

//            //    protected virtual void OnMyEvent()
//            //    {
//            //        MyEvent?.Invoke(this, EventArgs.Empty);
//            //    }
//            //}

//            //// Sample class to handle event
//            //class MyEventListener
//            //{
//            //    public void HandleEvent(object sender, EventArgs e)
//            //    {
//            //        Console.WriteLine("Event handled!");
//            //    }
//            //}
//        }
//    }
//}