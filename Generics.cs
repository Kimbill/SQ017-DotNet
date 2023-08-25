//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp12
//{    
//        class MyGenericClass<T>
//        {
//            private T data;

//            public MyGenericClass(T value)
//            {
//                data = value;
//            }

//            public T GetData()
//            {
//                return data;
//            }
//        }

//        //class Program
//        //{
//        //    static void Main(string[] args)
//        //    {
//        //        // Creating instances of MyGenericClass with different data types
//        //        MyGenericClass<int> intInstance = new MyGenericClass<int>(10);
//        //        MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello, Generics!");

//        //        // Using GetData method to retrieve data
//        //        int intData = intInstance.GetData();
//        //        string stringData = stringInstance.GetData();

//        //        // Displaying retrieved data
//        //        Console.WriteLine("Integer Data: " + intData);
//        //        Console.WriteLine("String Data: " + stringData);
//        //    }
//        //}
//}


////Generics in C# allow you to create classes, methods, and interfaces that can work with different data types
////while providing compile-time type safety.
////Generics increase code reusability and reduce code duplication by allowing you to write
////flexible and reusable components that can handle various data types without sacrificing type safety.

////Declaring a Generic Class:

////You declare a generic class using the angle brackets<T>,
////where T is a placeholder for the actual data type that will be provided
////when an instance of the class is created.

////Using the Generic Type Parameter:

////The type parameter T is used within the class to specify the type of fields,
////properties, methods, and parameters.

////Creating an Instance:

////When you create an instance of a generic class, you provide the actual data type
////that the class should work with.
