namespace Student_System;

internal class Person
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public int Pcn { get; set; }
    public int YearsAtSchool { get; set; }

    public Person(string fullName, int age, int pcn, int yearsAtSchool)
    {
        FullName = fullName;
        Age = age;
        Pcn = pcn;
        YearsAtSchool = yearsAtSchool;
    }

    public void CelebrateBirthday() { Age++; }
    public virtual void StartAnotherSchoolYear() { YearsAtSchool++; }

    public override string ToString()
    {
        return $"Name: {FullName}\n" +
               $"Age: {Age}\n" +
               $"PCN: {Pcn}\n" +
               $"Years at school: {YearsAtSchool}\n";
    }
}