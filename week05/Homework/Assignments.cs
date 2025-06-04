using System;

class Assignments
{
    protected string _studentName;
    protected string _topic;

    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{GetStudentName()} - {GetTopic()}");
    }
}