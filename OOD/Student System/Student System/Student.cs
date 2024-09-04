namespace Student_System;

internal class Student : Person
{
    public int NrOfECs { get; set; }

    public Student(int nrOfECs, string name, int age, int pcn, int yearsAtSchool) : base(name, age, pcn, yearsAtSchool)
    {
        NrOfECs = nrOfECs;
    }

    public void AddECs(int n) { NrOfECs += n; }

    public override string ToString()
    {
        string info = base.ToString();
        info += $"ECs: {NrOfECs}";
        return info;
    }
}