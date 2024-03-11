using Canvas.models;

public class Modules{

    public string? Name{get; set;}
    public string? Description{get; set;}
    public List<ContentItem> ?Content{get; set;}


    public Modules(){
        Content = new List<ContentItem>();
    }
    public Modules(string? name, string? desc){
        Name = name;
        Description = desc;
    }
        public override string ToString()
        {
          //string interpolation provides a better readable syntax  
            return $"({Name} {Description} {Content})";
        }

}