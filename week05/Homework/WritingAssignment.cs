using System;

public class WritingAssignment: Assignment
{
    private string _title;
    private string _studentName;


    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {   
        _title = title;
        _studentName = studentName;

    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }

}