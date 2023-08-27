using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GPACalculator
{
    class GPALogic
    {
        public static string Help()
        {
            var message = string.Empty;

            message = @"Course Code: Must start with three alphabeths and end with three numbers (Example: MTH102)
Course Unit: Must be integers between 1 and 9
Score:       Must be integer between 0 and 100

";

            return message;
        }

        public string AddCourseScore(string courseCode, int courseUnit, int score)
        {
            var message = string.Empty;
            var previousCount = CourseSheet.Results.Count;

            if (!Regex.IsMatch(courseCode, "[A-Z]{3}[0-9]{3}"))
            {
                message = "Please enter course in the right format";
            }

            if(score < 0 && score > 100)
            {
                message += "You entered an invalid score"; 
            }
            else
            {
                string grade = "";
                int gradeUnit;
                int weightPoint;
                string remark = "";

                if(score >= 70 && score <= 100)
                {
                    grade += "A";
                    gradeUnit = 5;
                    weightPoint = courseUnit * gradeUnit;
                    remark += "Excellent";
                }
                else if(score >= 60 && score < 70)
                {
                    grade += "B";
                    gradeUnit = 4;
                    weightPoint = courseUnit * gradeUnit;
                    remark += "Very Good";
                }
                else if (score >= 50 && score < 60)
                {
                    grade += "C";
                    gradeUnit = 3;
                    weightPoint = courseUnit * gradeUnit;
                    remark += "Good";
                }
                else if (score >= 45 && score < 50)
                {
                    grade += "D";
                    gradeUnit = 2;
                    weightPoint = courseUnit * gradeUnit;
                    remark += "Fair";
                }
                else if (score >= 40 && score < 45)
                {
                    grade += "E";
                    gradeUnit = 1;
                    weightPoint = courseUnit * gradeUnit;
                    remark += "Pass";
                }
                else
                {
                    grade += "F";
                    gradeUnit = 0;
                    weightPoint = courseUnit * gradeUnit;
                    remark += "Fail";
                }

                var course = new CourseModel(courseCode, courseUnit, score, grade, gradeUnit, weightPoint, remark);
                CourseSheet.Results.Add(course);
                var updatedCount = CourseSheet.Results.Count;

                if (updatedCount > previousCount)
                {
                    message = "Record was added successfully";
                }

            }
            return message;
            
        }

        public static string GetGPA()
        {
            var totalWeightPoint = 0;
            var totalGradePoint = 0;
            var totalGradePointPassed = 0;
            var totalGradeUnitRegistered = 0;

            foreach (var data in CourseSheet.Results)
            {
                if (data.Grade != "F")
                {
                    totalGradePointPassed += data.CourseUnit;
                }
                totalGradeUnitRegistered += data.CourseUnit;
                totalWeightPoint += data.CourseWeight;
                totalGradePoint += data.GradeUnit;
            }

            double gpa = totalWeightPoint / totalGradeUnitRegistered;

            return $"Total Grade Unit Registered is {totalGradeUnitRegistered}\n" +
                   $"Total Grade Unit Passed is {totalGradePointPassed}\n" +
                   $"Total Weight Point is {totalWeightPoint}\n" +
                   $"Your GPA is = {gpa:F2} to 2 decimal places.";


        }

        public static void PrintGradeSheet()
        {
            if (CourseSheet.Results.Count != 0)
            {
                Console.Clear();
                PrintTable.PrintLine();
                PrintTable.PrintRow("COURSE CODE", "COURSE UNIT", "SCORE", "GRADE", "GRADE UNIT", "WEIGHT POINT", "REMARK");
                PrintTable.PrintLine();
                foreach (var item in CourseSheet.Results)
                {
                    PrintTable.PrintRow(item.CourseCode, item.CourseUnit.ToString(), item.CourseScore.ToString(), item.Grade.ToString(), item.GradeUnit.ToString(), item.CourseWeight.ToString(), item.CourseRemark);
                    PrintTable.PrintLine();
                }
                Console.WriteLine(GetGPA());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please add your courses first");
            }
        }
    }
}
 