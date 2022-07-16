using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask;

public class StudentProfessorTest
{
    private IOutputWriter _writer;

    public StudentProfessorTest(IOutputWriter writer)
    {
        _writer = writer;
    }
    
    public void Run()
    {
        var person = new Person(_writer);
        var student = new Student(_writer);

        student.SetAge(21);
        student.ShowAge();
        student.Study();

        var teacher = new Professor(_writer);
        teacher.SetAge(40);
        teacher.Explain();
    }
}