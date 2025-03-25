public class Student : Person
{
    public string SchoolName { get; private set; }
    public Student(string name, int age, string schoolName)
        : base(name, age) 
    { 
        SchoolName = schoolName;
    }

    public override string ToString() { return base.ToString() + $" Школа: {SchoolName}"; }
}