//https://itnext.io/how-to-fully-cover-net-c-console-application-with-unit-tests-446927a4a793
//https://stackoverflow.com/questions/20595294/check-console-output-in-unit-test

using ReaClassMiniTask;
using ReaClassMiniTask.OutputWriter;


IOutputWriter outputWriter = new ConsoleOutputWriter();
var test = new StudentProfessorTest(outputWriter);
test.Run();


