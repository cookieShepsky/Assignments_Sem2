namespace Student_System;

internal class Teacher : Person
{
    private JobPosition _position;
    private double _salary;

    public Teacher(JobPosition position, double salary, string fullName, int age, int pcn, int yearsAtSchool) : base(fullName, age, pcn, yearsAtSchool)
    {
        _position = position;
        _salary = salary;
    }

    public void Promote()
    {
        if (_position != JobPosition.DIRECTOR)
            _position++;
    }

    public override string ToString()
    {
        string info = base.ToString()+"\n";
        info += $"Position: {_position}\n" +
                $"Salary: {_salary}\n";
        return info;
    }
}