namespace Student_System;

internal class Person
{
    private string _fullName;
    private int _age;
    private int _pcn;
    protected int _yearsAtSchool;

    public Person(string fullName, int age, int pcn, int yearsAtSchool)
    {
        _fullName = fullName;
        _age = age;
        _pcn = pcn;
        _yearsAtSchool = yearsAtSchool;
    }

    public void CelebrateBirthday() { _age++; }
    public virtual void StartAnotherSchoolYear() { _yearsAtSchool++; }

    public override string ToString()
    {
        return $"Name: {_fullName}\n" +
               $"Age: {_age}\n" +
               $"PCN: {_pcn}\n" +
               $"Years at school: {_yearsAtSchool}\n";
    }
}