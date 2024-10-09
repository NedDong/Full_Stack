namespace HW3School;

public class Instructor : Person, IInstructorService
{
    private decimal baseSalary;
    private decimal bonus;
    private DateTime joinDate;
    private bool isHead = false;

    public Instructor(string name, DateTime dateOfBirth, decimal baseSalary, DateTime joinDate) 
        : base(name, dateOfBirth, baseSalary)
    {
        this.baseSalary = baseSalary;
        this.joinDate = joinDate;
    }

    public decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - joinDate.Year;
        bonus = yearsOfExperience * 100;
        return baseSalary + bonus;
    }
    
    public void SetHead(Instructor instructor)
    {
        instructor.isHead = true;
    }
}