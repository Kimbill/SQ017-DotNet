using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Tuple
    {
        static (int, string) GetStudentInfo(int id)
        {
            // Simulating fetching data from a database
            if (id == 1)
            {
                return (1, "Alice");
            }
            else if (id == 2)
            {
                return (2, "Bob");
            }
            else
            {
                return (-1, "Not found");
            }
        }

        static void Main(string[] args)
        {
            int studentId = 1;
            var studentInfo = GetStudentInfo(studentId);

            Console.WriteLine($"Student ID: {studentInfo.Item1}, Name: {studentInfo.Item2}");
        }
    }
}

//A tuple is a lightweight data structure in C# that allows you to group a fixed number of elements with different data types. It's often used when you need to return multiple values from a method or store a temporary collection of related data.

//Tuple:

//Purpose:

//To group a fixed number of elements(fields) together, each with its own data type.
//Provides a simple way to work with multiple values without defining a new class or structure.
//Usage:

//When you need to return multiple values from a method.
//For temporary storage of related data.

//simulating fetching data from a database" means that the code is
//emulating the process of retrieving data from a database without actually connecting to a real database.
//This is done for the purpose of illustrating the concept without the complexity of interacting with a database.

//In the example, the GetStudentInfo method takes an id as a parameter
//and returns student information based on that id. However, since there is no actual database involved,
//the method uses conditional statements to provide sample student information.
//This is a simplified way to demonstrate how you might retrieve data from a database using a method.

//Steps

//The GetStudentInfo method is declared to return a tuple (int, string).
//This means that the method will return two values: an int(student ID) and a string (student name).

//Inside the GetStudentInfo method, a simulation is being used.
//When you call this method with an id, it checks the provided id to see if it matches predefined cases.

//If id is 1, the method returns a tuple (1, "Alice").
//This means that the student ID is 1, and the student name is "Alice".

//If id is 2, the method returns a tuple (2, "Bob").

//If neither 1 nor 2, the method returns a tuple (-1, "Not found").
//This is used as a placeholder to represent the case when a student with the given id is not found.

//In the Main method, we call GetStudentInfo with studentId set to 1.
//The returned tuple is assigned to the studentInfo variable.

//The studentInfo tuple is then accessed using the.Item1 and .Item2 properties
//to retrieve the student ID and student name respectively.

//Finally, we use Console.WriteLine to display the retrieved student ID and name.