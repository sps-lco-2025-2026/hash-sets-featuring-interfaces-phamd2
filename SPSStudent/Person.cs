using System.Dynamic;

namespace SPSStudent
{
    public enum SchoolYear
    {
        Year9, Year10, Year11, Year12, Year13
    }
    public class Person : SPSStudent
    {
        
        public readonly string Name;
        public readonly SchoolYear Year;
        public readonly string Tutor;

        string SPSStudent.Name => Name;
        SchoolYear SPSStudent.Year => Year;

        string SPSStudent.Tutor => Tutor;

        public Person(string name, SchoolYear year, string tutor)
        {
            Name = name;
            Year = year;
            Tutor = tutor;
        }

        public override string ToString()
        {
            return $" Student Name: {Name}, Year: {Year}, Tutor: {Tutor}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    
        public bool Equals(SPSStudent student)
        {
            if (student == null) return false;


            return Name == student.Name && Year == student.Year && Name == student.Tutor;
        }

    }
}