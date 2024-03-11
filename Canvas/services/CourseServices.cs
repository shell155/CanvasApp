using Canvas.models;

namespace Canvas.services {
    public class CourseServices{
        private IList<Course> listOfCourses;
        private static CourseServices? instance;
        private static object myLock = new object();
      
        public static CourseServices Current{ 
            get{
                lock(myLock){
                    if(instance == null){
                        instance = new CourseServices();
                    }
                }
                return instance;
            }
        }

        private CourseServices()
        {
            listOfCourses = new List<Course>();
            //{
                //new Course{Name = "Intro to Comp Sci",CourseCode = "COP330",courseId = 1}
           // }; 
        }

        public Course? Get(int id){
            var course = listOfCourses.FirstOrDefault(c => c.courseId == id);
            return course;
        }

        public void Add(Course course){
            if(course != null){
                listOfCourses.Add(course);
            }
        }

        public void Remove(int id){
            var course = Get(id);
            if(course != null){
                listOfCourses.Remove(course);
            }
        }

        public IList<Course> coursesList
        {
            get{
                return listOfCourses;
            }
        }

        public void Search()
        {


        }


       



}
}