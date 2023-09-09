namespace Structures
{
    public class Person
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }
}
