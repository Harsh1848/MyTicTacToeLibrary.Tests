using TicTacToe_Game.Models; // Import the namespace of the class you want to test
using Xunit;

namespace MyTicTacToeLibrary.Tests
{
    public class GameBoardTests
    {
        [Fact]
        public void DefaultBoard_HasCorrectSize()
        {
            // Arrange
            var gameBoard = new GameBoard();

            // Assert
            Assert.Equal(3, gameBoard.Board.GetLength(0));
            Assert.Equal(3, gameBoard.Board.GetLength(1));
        }

        [Fact]
        public void DefaultCurrentPlayer_IsX()
        {
            // Arrange
            var gameBoard = new GameBoard();

            // Assert
            Assert.Equal('X', gameBoard.CurrentPlayer);
        }

        [Fact]
        public void DefaultWinner_IsNull()
        {
            // Arrange
            var gameBoard = new GameBoard();

            // Assert
            Assert.Null(gameBoard.Winner);
        }
    }
}
