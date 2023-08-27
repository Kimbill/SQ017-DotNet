using System;
using System.Collections.Generic;
using System.Text;

namespace GPACalculator
{
    class CourseModel
    {
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int CourseScore { get; set; }
        public string Grade { get; set; }
        public int GradeUnit { get; set; }
        public int CourseWeight { get; set; }
        public string CourseRemark { get; set; }

        public CourseModel (string coursecode, int courseunit, int coursescore, string grade, int gradeunit, int courseweight, string courseremark)
        {
            CourseCode = coursecode;
            CourseUnit = courseunit;
            CourseScore = coursescore;
            Grade = grade;
            GradeUnit = gradeunit;
            CourseWeight = courseweight;
            CourseRemark = courseremark;
        }

    }
}
