using Moq;
using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask.UnitTests;

public class StudentProfessorTestUnitTest
{
    [Fact]
    public void Main()
    {
        // Arrange
        var age = 21;
        var ageMessage = $"My age is: {age} years old";
        var explainMessage = $"I'm explaining";
        var studyMessage = $"I'm studying";
        var helloMessage = "Hello!";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var test = new StudentProfessorTest(writer.Object);
        test.Run();

        // Assert
        writer.Verify(m => m.WriteLine(helloMessage), Times.Exactly(3));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == helloMessage)), Times.Exactly(3));
        
        writer.Verify(m => m.WriteLine(ageMessage), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == ageMessage)), Times.Exactly(1));
        
        writer.Verify(m => m.WriteLine(studyMessage), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == studyMessage)), Times.Exactly(1));

        writer.Verify(m => m.WriteLine(explainMessage), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == explainMessage)), Times.Exactly(1));
    }
}