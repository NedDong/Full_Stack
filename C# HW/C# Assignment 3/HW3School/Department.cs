namespace HW3School;

public class Department : IDepartmentService
{
    public Instructor Head { get;  set; }
    public decimal Budget { get;  set; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }
    private List<Course> courses = new List<Course>();

    public Department(decimal budget, DateTime startDate, DateTime endDate)
    {
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void SetHead(Instructor instructor)
    {
        Head = instructor;
    }

    public void OfferCourse(Course course)
    {
        courses.Add(course);
    }
}