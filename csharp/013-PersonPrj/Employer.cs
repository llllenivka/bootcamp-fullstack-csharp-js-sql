public class Employer : Person
{
    public int Salary { get; private set; }
    public Employer(string name, int age, int salary)
    : base(name, age)
    {
        Salary = salary;
    }

    public override string ToString() { return base.ToString() + $" Salary: {Salary}"; }

}