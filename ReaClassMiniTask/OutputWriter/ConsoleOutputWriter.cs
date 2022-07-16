namespace ReaClassMiniTask.OutputWriter;

public class ConsoleOutputWriter : IOutputWriter
{
    public void WriteLine(string s)
    {
        Console.WriteLine(s);
    }
}