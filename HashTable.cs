//using System;
//using System.Collections; // For HashTable
//using System.Collections.Generic; // For Dictionary


//namespace ConsoleApp12
//{
//    namespace HashTableAndDictionaryExample
//    {
//        class HashTable
//        {
//            static void Main(string[] args)
//            {
//                // HashTable
//                Hashtable hashTable = new Hashtable();
//                hashTable.Add("Name", "John");
//                hashTable.Add("Age", 30);
//                hashTable.Add("IsStudent", false);

//                Console.WriteLine("HashTable:");
//                foreach (DictionaryEntry entry in hashTable)
//                {
//                    Console.WriteLine($"{entry.Key}: {entry.Value}");
//                }
//                Console.WriteLine();

//                // Dictionary
//                Dictionary<string, int> dictionary = new Dictionary<string, int>();
//                dictionary.Add("One", 1);
//                dictionary.Add("Two", 2);
//                dictionary["Three"] = 3; // Another way to add key-value pair

//                Console.WriteLine("Dictionary:");
//                foreach (var kvp in dictionary)
//                {
//                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//                }
//            }
//        }
//    }

//}

////Both HashTable and Dictionary are used to store key-value pairs,
////but Dictionary is a more modern and efficient replacement for HashTable.

////HashTable:

////Data Structure:

////A collection of key-value pairs where keys must be unique.
////Uses a hash function to compute an index for each key, allowing fast retrieval.
////Usage:

////Good for storing a set of distinct values where key order doesn't matter.
////Not recommended for new code due to its legacy status.
////Dictionary:

////Data Structure:

////A generic collection of key - value pairs.
////Offers similar functionality to HashTable but is more efficient and type - safe.
////Usage:

////Recommended for storing key-value pairs in modern C# code.

////HashTable:
////Name: John
////Age: 30
////IsStudent: False

////Dictionary:
////One: 1
////Two: 2
////Three: 3
