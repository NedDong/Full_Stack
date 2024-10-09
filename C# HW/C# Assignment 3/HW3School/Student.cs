namespace HW3School;

public class Student : Person, IStudentService
{
    private List<Course> courses = new List<Course>();
    private List<string> grades = new List<string>();

    public Student(string name, DateTime dateOfBirth) : base(name, dateOfBirth, salary:0) {}

    public void EnrollCourse(Course course)
    {
        courses.Add(course);
    }

    public decimal CalculateGPA()
    {
        if (grades.Count == 0) return 0;

        decimal totalPoints = 0;
        foreach (var grade in grades)
        {
            totalPoints += GradeToPoints(grade);
        }
        return totalPoints / grades.Count;
    }

    private decimal GradeToPoints(string grade)
    {
        return grade switch
        {
            "A" => 4.0m,
            "B" => 3.0m,
            "C" => 2.0m,
            "D" => 1.0m,
            "F" => 0.0m,
            _ => 0.0m
        };
    }
}