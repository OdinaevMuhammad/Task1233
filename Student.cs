
public class Student : Person
{
    public int  numCourses = 0 ;
    private List<Object>  lists;
    public string [] courses ={};
    public int  [] grades = {} ;
    public Student( string name, string address) : base(name, address)
    {
         lists = new List<Object>();
    }
    public override string ToString()
    {
        return Name + " " + Address;
    }

    public List<Object> GetList()
    {
        return lists;
    }
    public void AddCourseGread(string courses, int grades, List<object> lists)
    {

        numCourses++;
        lists.Add(courses , grades);
    }
    public void PrintGrades()
    {


        foreach (var item in lists)
        {
            System.Console.WriteLine(item.grades);
        }
    }

}