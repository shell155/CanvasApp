namespace Canvas.models {

public class Person{
  //properties
    public string? FirstName{get; set;}
    public int? ID{get; set;}
    public string? LastName{get;set;}
   public PersonClassification classification{get; set;}
   public string? major{get; set;}
    public Dictionary<int,double> ? grades{get; set;}
    public DateOnly? DateOfBirth{get; set;}
  public Person()
    {
      grades = new Dictionary<int, double>();
    }
  
  public Person(string? Fname, string? Lname, int? ID ,char classi, string? Major, Dictionary<int,double> Grades, DateOnly? DOB){
    FirstName = Fname;
    LastName = Lname;
    this.ID = ID;
    classification = (PersonClassification)classi;
    major = Major;
    DateOfBirth = DOB;
    grades = Grades;
  }
  
        public override string ToString()
        {
          //string interpolation provides a better readable syntax  
            return $"({FirstName} {LastName} -- [{ID}] {major} {classification} {DateOfBirth})";
        }

      
    }


    public  enum PersonClassification{
            Freshman,Sophmore, Junior, Senior
        

        }
}