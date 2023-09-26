using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class GradingStudents
    {
        // https://www.hackerrank.com/challenges/grading/problem

        internal void TakeInput()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            List<int> result = gradingStudents(grades);
            result.All(s => { Console.WriteLine(s); return true; });
            Console.ReadLine();
        }

        private List<int> gradingStudents(List<int> grades)
        {
            List<int> updatedGrades = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                int currentStudentGrade = grades[i];
                if (currentStudentGrade >= 38)
                {
                    int nextRoundedValue = (currentStudentGrade / 5 + 1) * 5;

                    if ((nextRoundedValue - currentStudentGrade) < 3)
                    {
                        updatedGrades.Add((int)nextRoundedValue);
                        continue;
                    }
                }
                updatedGrades.Add(currentStudentGrade);
            }
            return updatedGrades;
        }
    }
}
