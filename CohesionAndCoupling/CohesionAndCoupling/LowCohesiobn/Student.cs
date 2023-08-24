
namespace CohesionAndCoupling.LowCohesiobn
{
	public class Student
	{
		private string id;
        public string Id
        {
            get
            {
                return this.id;
            }
        }

        private string name;
		public string Name {
			get {
				return this.name;
			}
		}

		private string address;
		public string Address {
			get {
				return this.address;
			}
		}

		private double[] grades;
		public double[] Grades {
			get {
				return this.grades;
			}
		}

		public Student(string id, string name, string address, double[] grades)
		{
			this.id = id;
			this.name = name;
			this.address = address;
			this.grades = grades;
		}
	}
}
