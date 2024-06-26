using ToyRobot.Repository;

namespace ToyRobot.Tests;

public class RobotTests
{
    [Fact]
    public void TestRobotMovement_EqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        robot.Place(0, 0, "NORTH");

        // Act
        robot.Move();

        // Assert
        Assert.Equal("0,1,NORTH", robot.Report());
    }

    [Fact]
    public void TestRobotLeftTurn_EqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        robot.Place(0, 0, "NORTH");

        // Act
        robot.Left();

        // Assert
        Assert.Equal("0,0,WEST", robot.Report());
    }

    [Fact]
    public void TestRobotRightTurn_EqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        robot.Place(0, 0, "NORTH");

        // Act
        robot.Right();

        // Assert
        Assert.Equal("0,0,EAST", robot.Report());
    }

    [Fact]
    public void TestRobotCommandsFromFile_EqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        Command command = new Command(robot);
        CommandParser commandParser = new CommandParser(command);

        // Act
        string[] commands = { "PLACE 0,0,NORTH", "MOVE", "RIGHT", "REPORT" };
        foreach (var cmd in commands)
        {
            commandParser.ParseCommand(cmd);
        }

        // Assert
        Assert.Equal("0,1,EAST", robot.Report());
    }

    [Fact]
    public void TestRobotMovement_NotEqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        robot.Place(0, 0, "NORTH");

        // Act
        robot.Move();

        // Assert
        Assert.NotEqual("0,0,NORTH", robot.Report());
    }

    [Fact]
    public void TestRobotLeftTurn_NotEqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        robot.Place(0, 0, "NORTH");

        // Act
        robot.Left();

        // Assert
        Assert.NotEqual("0,0,EAST", robot.Report());
    }

    [Fact]
    public void TestRobotRightTurn_NotEqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        robot.Place(0, 0, "NORTH");

        // Act
        robot.Right();

        // Assert
        Assert.NotEqual("0,0,WEST", robot.Report());
    }

    [Fact]
    public void TestRobotCommandsFromFile_NotEqualTest()
    {
        // Arrange
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        Command command = new Command(robot);
        CommandParser commandParser = new CommandParser(command);

        // Act
        string[] commands = { "PLACE 0,0,NORTH", "MOVE", "RIGHT", "REPORT" };
        foreach (var cmd in commands)
        {
            commandParser.ParseCommand(cmd);
        }

        // Assert
        Assert.NotEqual("0,0,EAST", robot.Report());
    }
}