namespace HW3School;

public abstract class Person : IPersonService
{
    private string name;
    private DateTime dateOfBirth;
    private decimal salary;
    private List<string> addresses = new List<string>();

    public Person(string name, DateTime dateOfBirth, decimal salary)
    {
        this.name = name;
        this.dateOfBirth = dateOfBirth;
        if (salary < 0)
        {
            salary = 0;
        }else{this.salary = salary;}
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - dateOfBirth.Year;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }

    public string GetName()
    {
        return name;
    }
    
    public decimal CalculateSalary()
    {
        return salary;
    }
}