Prequisites:
VS Code Extensions intalled:
    C# Dev Kit: for support of .NET solutions (.sln) and projects templates
    .NET Core Test Explorer: for support of xunit tests

1. Create a new .NET 8 library project
2. Create a new .NET 8 console application
3. Add a reference to the MyMathLibrary project in the console application
    dotnet add c:\Users\merhautf\repos\solutionlesson01\ConsoleControl\ConsoleControl.csproj reference c:\Users\merhautf\repos\solutionlesson01\MyMathLibrary\MyMathLibrary.csproj 
4. Add using directive to Program.cs
    using MyMathLibrary;
5. Test MyMathLibrary.Class1.Add(2, 3) in the ConsoleControl project
6. Create xunit test project (CTRL+SHIFT+P, New project, Unit test project)
7. Add a reference to the MyMathLibrary project in the test project
    dotnet add c:\Users\merhautf\repos\solutionlesson01\XUnitTests\XUnitTests.csproj reference c:\Users\merhautf\repos\solutionlesson01\MyMathLibrary\MyMathLibrary.csproj 
8. Add using directive to UnitTest1.cs
    using MyMathLibrary;
9. Define test methods in UnitTest1.cs ([Fact], [Theory], [InlineData])
9. Go to "Testing" tab in the VS Code and run the tests in the test project
    alternatively, you can run the tests from the command line
        dotnet test
        (in the folder with test project)
You can check https://www.youtube.com/watch?v=04nzwCE_nw0 for reference how to add references
Overview of testing, unit testing: https://www.youtube.com/watch?v=MpeMJ0XqgYg
