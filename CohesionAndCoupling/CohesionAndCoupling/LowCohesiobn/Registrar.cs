using System;
namespace CohesionAndCoupling.LowCohesiobn
{
	public class Registrar
	{
		public Registrar()
		{
		}

        public void PrintTranscript(Student student, Teacher teacher)
        {
            Console.WriteLine("Student Transcript");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("ID: " + student.Id);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Average Grade: " + teacher.ComputeAverageGrade(student));
        }
    }
}

