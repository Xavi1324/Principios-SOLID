namespace OCP.Course
{
    public abstract class Course
    {
        
        public int courseId {  get; set; }
        public string Title { get; set; }

        public abstract void Subcribe(Student std);
    }

}
