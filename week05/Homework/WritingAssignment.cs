using System;
class WritingAssignment : Assignments
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - {GetTopic()}\n{GetTitle()}";
    }
}