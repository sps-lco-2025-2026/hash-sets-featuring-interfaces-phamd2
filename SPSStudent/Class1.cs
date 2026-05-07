namespace SPSStudent;

public class SPS : Person
{

    public string SchoolYear;
   public string yearGroup;



   public Student(string firstname, string lastname, string dob, string email, string schoolYear, string yearGroup) : base(firstname, lastname, dob, email)
   {
      schoolYear = CalculateSchoolYear(dob);
      yearGroup = CalculateEstimatedYear();

   }

   private string CalculateSchoolYear(string dob)
   {
      DateTime dobDateTime = DateTime.Parse(dob);
      return $"{DateTime.Now.Year - dobDateTime.Year}";
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
