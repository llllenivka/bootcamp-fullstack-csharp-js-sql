public class Teacher : Person
{
    public string Subject { get; private set; }
    public Teacher(string name, int age, string subject)
    : base(name, age)
    {
        Subject = subject;
    }

    public override string ToString() { return base.ToString() + $" Subject: {Subject}."; }

}
