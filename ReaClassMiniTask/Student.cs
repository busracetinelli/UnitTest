using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask;

public class Student : Person
{
    public Student(IOutputWriter writer) : base(writer)
    {
    }
    public void Study()
    {
        Writer.WriteLine("I'm studying");
    }
}