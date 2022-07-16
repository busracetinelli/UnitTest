using Moq;
using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask.UnitTests;

public class ProfessorTest
{
    [Fact]
    public void CreateProfessorShouldBeWriteHelloInConsole()
    {
        // Arrange
        var message = "Hello!";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var professor = new Professor(writer.Object);

        // Assert
        writer.Verify(m => m.WriteLine(message), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == message)), Times.Once);
    }
    
    [Fact]
    public void ExplainShouldBeReturnCorrectMessage()
    {
        // Arrange
        var message = $"I'm explaining";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var professor= new Professor(writer.Object);
        professor.Explain();

        // Assert
        writer.Verify(m => m.WriteLine(message), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == message)), Times.Once);
    }
}