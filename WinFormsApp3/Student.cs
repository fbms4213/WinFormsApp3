namespace WinFormsApp3;

class Student
{
    private static int _staticId = 0;

    public int Id { get; set; }
    public string? Name { get; set; }

    public Student(string? name)
    {
        Id = ++_staticId;
        Name = name;
    }

    public override string ToString()
     => $"{Id} - {Name}";
}
