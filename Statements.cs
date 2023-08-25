//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp12
//{   
//    class Statements
//    {

//        static void Dotnet(int[] numbers)
//        {
//            foreach (int number in numbers)
//            {
//                if (number % 2 == 0)
//                    Console.WriteLine($"{number} is even");
//                else
//                    Console.WriteLine($"{number} is odd");
//            }
//        }
//        static void Main()
//        {

//            int[] container = { 2, 3, 6, 9, 12, 15 };
//            int[] Vehicles = { 10, 20 };
//            Dotnet(container);
//            Dotnet(Vehicles);
//            //int dotNetSize = 18;

//            //if (dotNetSize < 18)
//            //{
//            //    Console.WriteLine(  "It has not exceeded its Limit"); 
//            //}

//            //else if (dotNetSize >= 18 && dotNetSize < 30)
//            //{
//            //    Console.WriteLine("It is allowed");
//            //}

//            //else if (dotNetSize > 35)
//            //{
//            //    Console.WriteLine("");
//            //}

//            //else
//            //{
//            //    Console.WriteLine("Above expected number");
//            //}

//            //int[] numbers = { 1, 2, 3, 4, 5 };

//            //foreach (int no in numbers)
//            //{
//            //    //this is to print out the number
//            //    Console.WriteLine(no);
//            //}

//            //string words = "123";

//            //int number = Convert.ToInt32(words);
//            //Console.WriteLine($"converted number: {number}");

//            //char grade = 'C';

//            //switch (grade)
//            //{
//            //    case 'A':
//            //        Console.WriteLine("Excellent");
//            //        break;
//            //    case 'B':
//            //        Console.WriteLine("Very Good");
//            //        break;
//            //    case 'C':
//            //        Console.WriteLine("Average");
//            //        break;
//            //    case 'D':
//            //        Console.WriteLine("Bad");
//            //        break;

//            //int count = 1;

//            //while (count <= 5)
//            //{
//            //    Console.WriteLine($"Iterate through values for {count}");
//            //}



//        }
//    }

//}

//Arrays:

//Linear Array: A one-dimensional collection of elements stored in contiguous memory locations.
//Multi-Dimensional Array: An array with two or more dimensions, organized in rows and columns.
//Jagged Array: An array of arrays, where each sub-array can have a different length.
//ArrayList:
//ArrayList is a non-generic collection of objects whose size increases dynamically. 
//It is the same as Array except that its size increases dynamically. 
//An ArrayList can be used to add unknown data where you don't know the types and the size of the data.
//A dynamically resizable array-like collection that can hold elements of different data types. However, it's less efficient than generic collections.
//Generics:

//Allows you to create type-safe and reusable classes, methods, and interfaces that operate on any type while providing compile-time type checking.
//List:

//A generic collection that stores elements in an ordered manner and allows for dynamic resizing.
//Stacks:

//A Last-In-First-Out (LIFO) data structure that stores elements and supports operations like push (add) and pop(remove).
//Queues:

//A First-In - First - Out(FIFO) data structure that stores elements and supports operations like enqueue (add) and dequeue(remove).
//HashTable:

//A legacy collection that stores key-value pairs, ensuring uniqueness of keys. It's replaced by the more efficient Dictionary in modern .NET.
//Dictionary:

//A collection that stores key-value pairs, allowing quick retrieval of values based on their associated keys.
//Tuple:

A lightweight data structure that can hold a fixed number of elements with different data types.
//Indexer:

//A mechanism to access elements of a class like an array using custom-defined syntax.
//Delegates:

//A type-safe function pointer that refers to a method. Lambdas provide syntactic sugar to define delegates inline.
//Events:

//A mechanism that allows objects to notify other objects when an action occurs. They're widely used for implementing the observer pattern.
//The provided code in the previous response demonstrates these concepts in a .NET 6 program. Run the code, and you'll see examples of each concept in action along with their outputs.
