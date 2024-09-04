namespace Student_System;

internal class Teacher : Person
{
    public JobPosition Position { get; set; }
    public double Salary { get; set; }

    public Teacher(JobPosition position, double salary, string fullName, int age, int pcn, int yearsAtSchool) : base(fullName, age, pcn, yearsAtSchool)
    {
        Position = position;
        Salary = salary;
    }

    public void Promote()
    {
        if (Position != JobPosition.DIRECTOR)
            Position++;
    }

    public override void StartAnotherSchoolYear()
    {
        base.StartAnotherSchoolYear();
        if (base.YearsAtSchool % 3 == 0)
            Salary *= 1.1;
    }

    public override string ToString()
    {
        string info = base.ToString()+"\n";
        info += $"Position: {Position}\n" +
                $"Salary: {Salary}\n";
        return info;
    }
}