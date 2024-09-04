namespace Student_System;

internal class Administration
{
    public List<Person> Persons { get; } = [];
    public List<Student> Students { get; } = [];
    public List<Teacher> Teachers { get; } = [];

    public Administration(){}

    // Removed getters en "adders" , since I used Properties.

    public Person? GetPerson(int pcn)
    {
        foreach (Person p in Persons)
            if (p.Pcn == pcn)
                return p;
        return null;
    }

    public Student? GetStudent(int pcn)
    {
        foreach (Student p in Students)
            if (p.Pcn == pcn)
                return p;
        return null;
    }

    public Teacher? GetTeacher(int pcn)
    {
        foreach (Teacher p in Teachers)
            if (p.Pcn == pcn)
                return p;
        return null;
    }

}