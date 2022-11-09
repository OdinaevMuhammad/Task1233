

public class Teacher : Person
{ 
    public int  numCourses = 0 ;
    public string [] courses = {} ;
    private List<Object> lists;
    public Teacher( string name, string address) : base(name, address)
    {
        lists = new List<Object>();
    }
    public void AddCourse(string courses)
    {
        lists.Add(courses);
    }

    
    
}