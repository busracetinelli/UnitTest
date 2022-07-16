using Moq;
using ReaClassMiniTask.OutputWriter;

namespace ReaClassMiniTask.UnitTests;

public class PersonTest
{
    [Fact]
    public void CreatePersonShouldBeWriteHelloInConsole()
    {
        // Arrange
        var message = "Hello!";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var person = new Person(writer.Object);

        // Assert
        writer.Verify(m => m.WriteLine(message), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == message)), Times.Once);
    }
    
    [Fact]
    public void ShowAgeShouldBeReturnSettingAge()
    {
        // Arrange
        var age = 21;
        var message = $"My age is: {age} years old";
        var writer = new Mock<IOutputWriter>();
        
        // Act
        var person = new Person(writer.Object);
        person.SetAge(age);
        person.ShowAge();

        // Assert
        writer.Verify(m => m.WriteLine(message), Times.Exactly(1));
        writer.Verify(w => w.WriteLine(It.Is<string>(s => s == message)), Times.Once);
    }
}