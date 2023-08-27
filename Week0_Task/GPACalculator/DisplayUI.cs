using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GPACalculator
{
    class DisplayUI
    {
        public void GPAApp()
        {
            var userScore = new GPALogic();

            Console.WriteLine("******Obafemi Awolowo University*******");
            Console.WriteLine("********GPA Calculator*********");
            Console.WriteLine("");
            Console.WriteLine("Press enter to start");
            var userInput = Console.ReadLine();
            Console.Clear();

            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Press 1 to Add Course Score");
                Console.WriteLine("Press 2 to Print Result Sheet");
                Console.WriteLine("Type \"help\" for instructions");
                Console.WriteLine("");

                var userChoice = Console.ReadLine();

                if(userChoice == "2")
                {
                    Console.Clear();
                    GPALogic.PrintGradeSheet();
                }

                else if (userChoice == "1")
                {
                    // input parameters to add course score
                    var courseCode = "";
                    int courseUnit = 0;
                    var score = 0;


                    Console.Clear();
                    // Course Code Validity Check
                    var isCourseCode = true;
                    while (isCourseCode)
                    {
                        Console.WriteLine("Enter Course Code");
                        var input = Console.ReadLine();

                        if (input.ToLower() == "help")
                        {
                            Console.Clear();
                            Console.WriteLine(GPALogic.Help());
                            continue;
                        }
                        else if (!Regex.IsMatch(input, "[A-Z]{3}[0-9]{3}"))
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter course in the right format or type \"help\" for instructions");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            courseCode += input;
                            isCourseCode = false;
                        }
                    }

                    Console.Clear();
                    // Course Unit Validity Check
                    var isCourseUnit = true;
                    while (isCourseUnit)
                    {
                        Console.WriteLine("Enter Course Unit");
                        var input = Console.ReadLine();

                        if (input.ToLower() == "help")
                        {
                            Console.Clear();
                            Console.WriteLine(GPALogic.Help());
                            continue;
                        }
                        else if (!Regex.IsMatch(input, "[0-9]{1}"))
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter course unit in the right format or type \"help\" for instructions");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            courseUnit = int.Parse(input);
                            isCourseUnit = false;
                        }
                    }

                    Console.Clear();
                    // Course Score Validity Check
                    var isScore = true;
                    while (isScore)
                    {
                        Console.WriteLine("Enter score Obtained");
                        var input = Console.ReadLine();

                        if (input.ToLower() == "help")
                        {
                            Console.Clear();
                            Console.WriteLine(GPALogic.Help());
                            continue;
                        }
                        else if (!(score >= 0 && score <= 100))
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Score. Type \"help\" for instructions");
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            score = int.Parse(input);
                            isScore = false;
                        }
                    }

                    Console.WriteLine(userScore.AddCourseScore(courseCode, courseUnit, score));


                }

                else if(userChoice.ToLower() == "help")
                {
                    Console.Clear();
                    Console.WriteLine(GPALogic.Help()); 
                }
            }
        }
        
    }
}
