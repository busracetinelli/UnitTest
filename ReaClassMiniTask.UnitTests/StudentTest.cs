using Moq;
using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask.UnitTests;

public class StudentTest
{
    [Fact]
    public void CreateStudentShouldBeWriteHelloInConsole()
    {
        // Arrange
        var message = "Hello!";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var student = new Student(writer.Object);

        // Assert
        writer.Verify(m => m.WriteLine(message), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == message)), Times.Once);
    }
    
    [Fact]
    public void StudyShouldBeReturnCorrectMessage()
    {
        // Arrange
        var message = $"I'm studying";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var student= new Student(writer.Object);
        student.Study();

        // Assert
        writer.Verify(m => m.WriteLine(message), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == message)), Times.Once);
    }

}