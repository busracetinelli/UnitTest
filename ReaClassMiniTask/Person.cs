using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask;

public class Person
{
    protected readonly IOutputWriter Writer;

    private int Age { get; set; }
    
    public Person(IOutputWriter writer)
    {
        Writer = writer;
        Greet();
    }
    public void Greet()
    {
        Writer.WriteLine("Hello!");
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    public void ShowAge()
    {
        Writer.WriteLine($"My age is: {Age} years old");
    }

}