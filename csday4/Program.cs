//Internal defined inside the class only

//Object class->Object
public class Student //Template for an object
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Address { get; set; }

    public Student(int id)
    {
        this.Id = id;
    }


}
//Logical Class->Class
public class StudentOperations
{
    //LIST COLLECTION
    List<Student> students = new List<Student>();  //SAVE INFO DB
    public void Add(Student st)//INSERT
    {
        students.Add(st);
    }
    public void GetById(int id) //READING
    {
        for (int i = 0; i < students.Count(); i++)
        {
            if (id == students[i].Id)
            {
                Console.WriteLine($" Id:{students[i].Id} Name:{students[i].Name}, Address:{students[i].Address}");
                break;
            }
        }
    }
    public void GetAll()
    {
        for (int i = 0; i < students.Count(); i++)
        {
            Console.WriteLine($" Id:{students[i].Id} Name:{students[i].Name}, Address:{students[i].Address}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student st = new Student(2);
        st.Name = "Kural";
        st.Address = "DPM";

        StudentOperations s = new StudentOperations();

         s.Add(st);
        Student st1 = new Student(3);
        st1.Name = "Krishna";
        st1.Address = "Chennimalai";
        s.Add(st1);

        Student st2 = new Student(4);
        st2.Name = "Kural";
        st2.Address = "DPM";

        s.Add(st2);
        s.GetAll();

    }
}