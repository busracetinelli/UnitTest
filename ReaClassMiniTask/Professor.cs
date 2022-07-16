using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask;

public class Professor : Person
{
    public Professor(IOutputWriter writer) : base(writer)
    {
    }
    public void Explain()
    {
        Writer.WriteLine("I'm explaining");
    }
}