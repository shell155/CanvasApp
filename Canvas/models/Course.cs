namespace Canvas.models;

public class Course{
  //properties
    public string? Name{get; set;}
    public int courseId{get; set;}
    public string? CourseCode{get; set;}
    public string? Description{get; set;}
    public List<Modules> ?Modules{get; set;}
    public List<Assignment> ?Assignments{get; set;}
    public List<Person> ?Roster{get; set;}
    public List<Person> ?Instructors{get; set;}


public Course(){
    Modules = new List<Modules>();
    Assignments = new List<Assignment>();
    Roster = new List<Person>();
    Instructors = new List<Person>();
}
public Course(string? name, string? code, string? desc){
  Name = name;
  CourseCode = code;
  Description = desc;
}
    public override string ToString()
    {
      //string interpolation provides a better readable syntax  
        return $"({Name} {CourseCode} , {Description} {Modules} {Assignments} {Roster} {Instructors})";
    }
}