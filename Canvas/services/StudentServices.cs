using Canvas.models;

namespace Canvas.services {
   public class StudentServices{
        private IList<Person> listOfStudents; //making it an interface that I could make it any type of list
        private static StudentServices? instance;
        private string? query;
        private static object myLock = new object();
      //Singleton pattern. 
        public static StudentServices Current{ 
            get{
                //only call to the constructor. 
                lock(myLock){
                    if(instance == null){
                        instance = new StudentServices();
                    }
                }
                return instance;
            }
        }

        private StudentServices()
        {
            listOfStudents = new List<Person>();
            //{
                //new Person{FirstName = "Shelley",ID = 1,LastName = "Bercy", classification = PersonClassification.Senior,major = "Comp sci"}
           // }; 
        }

        public Person? Get(int id){
            var student = listOfStudents.FirstOrDefault(s => s.ID == id);
            return student;
        }

        public void AddStudent(Person student){
            if(student != null){
                listOfStudents.Add(student);
            }
        }

        public void Delete(Person studentToDel)
        {
            listOfStudents.Remove(studentToDel);
        }

        public IList<Person> StudentList
        {
            get{
                return listOfStudents;
            }
        }



        //search Student
        public IEnumerable<Person> Students
        {
            get {
                    return listOfStudents.Where(c => c.FirstName.ToUpper().Contains(query?? string.Empty) || c.LastName.ToUpper().Contains(query ?? string.Empty));
                }
        }

        public IEnumerable<Person> Search(string query)
        {
            this.query = query;
            return Students; 
        }

       
    } 






}