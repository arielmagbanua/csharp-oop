using System;
namespace CohesionAndCoupling.LowCohesiobn
{
	public class Teacher
	{
		public Teacher()
		{
		}

        public double ComputeAverageGrade(Student student)
        {
            double sum = 0.0;

            foreach (double grade in student.Grades)
            {
                sum += grade;
            }

            return sum / student.Grades.Length;
        }
    }
}

