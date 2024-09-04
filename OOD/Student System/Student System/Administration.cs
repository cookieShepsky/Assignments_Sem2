namespace Student_System;

internal class Administration
{
    public List<Person> Persons { get; set; } = [];
    public List<Student> Students { get; set; } = [];
    public List<Teacher> Teachers { get; set; } = [];

    public Administration(){}

    public void AddPerson(Person p){ Persons.Add(p); }

    public void AddStudent(Student s){ Students.Add(s); }

    public void AddTeacher(Teacher t){ Teachers.Add(t); }

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

    // Removed getters, since I use Properties
}