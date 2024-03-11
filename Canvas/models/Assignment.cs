namespace Canvas.models {

public class Assignment{
  //properties
    public string? Name{get; set;}
    public string? Description{get;set;}
    public int? TotalAvaiablePoints{get; set;}
    public DateOnly? DueDate{get; set;}
  public Assignment(){}
  public Assignment(string? name, string? desc, int? points, DateOnly? date){
    Name = name;
    Description = desc;
    TotalAvaiablePoints = points;
    DueDate = date;
  }
        public override string ToString()
        {
          //string interpolation provides a better readable syntax  
            return $"({Name} {Description} , {TotalAvaiablePoints} {DueDate})";
        }
}
}



