using System.Dynamic;

namespace SPSStudent
{
    public class Person :
    {
        
        public string Name { get; }
        public SchoolYear Year { get; }
        public string Tutor { get; }

        string SPSStudent.Year => this.Year.ToString();

        public Person(string name, SchoolYear year, string tutor)
        {
            Name = name;
            Year = year;
            Tutor = tutor;
        }

        public override string ToString()
        {
            return $"[Student] Name: {Name}, Year: {Year}, Tutor: {Tutor}";
        }

        public bool Equals(SPSStudent other)
        {
            if (other == null) return false;
            return Name == other.Name && Year.ToString() == other.Year && Tutor == other.Tutor;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SPSStudent);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Year, Tutor);
        }
    

        private string CalculateEstimatedYear()
        {
            int age = CalculateAge();
            if (age >= 5 && age <=17)
                return $"Year {age-4}";
            else if (age == 4)
                return "Reception";
            else
                return "Invalid Year";
        }

    }
}