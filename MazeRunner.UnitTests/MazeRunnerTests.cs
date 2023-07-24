using DTSCodeDojo.MazeRunnerChallenge;
using FluentAssertions;

namespace DTSCodeDojo.MazeRunnerTests
{
    public class MazeRunnerTests
    {
        private readonly MazeRunner _mazeRunner;
        private readonly int[,] _maze;

        public MazeRunnerTests()
        {
            _mazeRunner = new MazeRunner();
            _maze = new int[,] { { 1, 1, 1, 1, 1, 1, 1 },
                           { 1, 0, 0, 0, 0, 0, 3 },
                           { 1, 0, 1, 0, 1, 0, 1 },
                           { 0, 0, 1, 0, 0, 0, 1 },
                           { 1, 0, 1, 0, 1, 0, 1 },
                           { 1, 0, 0, 0, 0, 0, 1 },
                           { 1, 2, 1, 0, 1, 0, 1 } };
        }

        [Fact]
        public void RunMaze_WhenPassedEmptyValues_ReturnLost()
        {
            var maze = new int[0, 0];
            var directions = Array.Empty<string>();
            var mazeResult = _mazeRunner.RunMaze(maze, directions);
            mazeResult.Should().Be("Lost");
        }

        [Theory]
        [InlineData("N")]
        [InlineData("N", "E", "E", "E", "E")]
        public void RunMaze_WhenPassedAMazeWithDirectionsToNotFindFinish_ReturnLost(params string[] directions)
        {
            var mazeResult = _mazeRunner.RunMaze(_maze, directions);
            mazeResult.Should().Be("Lost");
        }

        [Theory]
        [InlineData("N", "N", "N", "W", "W")]
        [InlineData("N", "N", "N", "N", "N", "E", "E", "S", "S", "S", "S", "S", "S")]
        public void RunMaze_WhenPassedAMazeWithDirectionsToHitWall_ReturnDead(params string[] directions)
        {
            var mazeResult = _mazeRunner.RunMaze(_maze, directions);
            mazeResult.Should().Be("Dead");
        }

        [Theory]
        [InlineData("N", "N", "N", "N", "N", "E", "E", "E", "E", "E")]
        [InlineData("N", "N", "N", "N", "N", "E", "E", "S", "S", "E", "E", "N", "N", "E")]
        [InlineData("N", "N", "N", "N", "N", "E", "E", "E", "E", "E", "W", "W")]
        public void RunMaze_WhenPassedAMazeWithCorrectDirections_ReturnFinish(params string[] directions)
        {
            var mazeResult = _mazeRunner.RunMaze(_maze, directions);
            mazeResult.Should().Be("Finish");
        }

        [Fact]
        public void RunMaze_WhenDifferentMazeIsUsedWithCorrectDirections_ReturnFinish()
        {
            var maze = new int[,] { { 1, 1, 3 },
                                    { 1, 0, 0 },
                                    { 2, 0, 1 } };

            var directions = new string[] { "E", "N", "E", "N" };
            var mazeResult = _mazeRunner.RunMaze(maze, directions);
            mazeResult.Should().Be("Finish");
        }
    }
}

