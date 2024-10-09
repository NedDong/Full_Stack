namespace HW3School;

public class Course : ICourseService
{
    private string courseName;
    private List<Student> enrolledStudents = new List<Student>();

    public Course(string courseName)
    {
        this.courseName = courseName;
    }

    public void EnrollStudent(Student student)
    {
        enrolledStudents.Add(student);
    }
}