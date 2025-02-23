using System;

namespace StudentLibrary;

public class StudentQueryResult
{
    public List<Student> Results { get; set; } = new();
    public int Total => Results.Count;
}
