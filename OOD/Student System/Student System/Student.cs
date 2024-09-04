namespace Student_System;

internal class Student : Person
{
    private int _nrOfECs;

    public Student(int nrOfECs, string name, int age, int pcn, int yearsAtSchool) : base(name, age, pcn, yearsAtSchool)
    {
        _nrOfECs = nrOfECs;
    }

    public void AddECs(int n) { _nrOfECs += n; }
}