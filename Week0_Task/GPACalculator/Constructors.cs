//using System;

//namespace ConstructorsExample
//{
//    class Student
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        // Default constructor
//        public Student()
//        {
//            Name = "Unknown";
//            Age = 0;
//        }

//        // Parameterized constructor
//        public Student(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }

//        // Method to display student information
//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Name: {Name}, Age: {Age}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Using default constructor
//            Student student1 = new Student();
//            student1.DisplayInfo();

//            // Using parameterized constructor
//            Student student2 = new Student("Alice", 20);
//            student2.DisplayInfo();
//        }
//    }
//}

////In C#, constructors are special methods within a class that are used to initialize objects of that class.
////Constructors have the same name as the class and do not have a return type.
////They are called when an object of the class is created using the new keyword.
////Constructors can be overloaded, allowing you to create objects with different initial states.