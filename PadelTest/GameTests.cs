using System;
using Xunit;
using Padel;

namespace PadelTest
{
    
    public class GameTests
    {
    
       [Fact]
        public void Game_GameIsNotNull()
        {
            var player1 = new Player("Erik");
            var player2 = new Player("Isak");

            var game = new Game(player1, player2);

            Assert.NotNull(game);

        }
        
        [Fact]
        public void Game_Player1IsNotNull()
        {
            var player1 = new Player("Erik");
            var player2 = new Player("Isak");

            var game = new Game(player1, player2);

            Assert.NotNull(game._player1);
        }

        [Fact]
        public void Game_Player2IsNotNull()
        {
            var player1 = new Player("Erik");
            var player2 = new Player("Isak");

            var game = new Game(player1, player2);
            Assert.NotNull(game._player2);

        }

        [Fact]
        public void Game_Player2IsNull()
        {
            var player1 = new Player("Erik");
            var player2 = new Player("Isak");

            var game = new Game(player1, null);
            Assert.Null(game._player2);
        }

        [Fact]
        public void Game_Player1AndPlayer2_CorectlySet()
        {
            var player1 = new Player("Erik");
            var player2 = new Player("Isak");

            var game = new Game(player1, player2);
            Assert.Equal(player1, game._player1);
            Assert.Equal(player2, game._player2);

        }

        
        [Fact]
        public void Point_AddPointToPlayer1()
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");

            var game = new Game(player1, player2);
            game.Point(player1); // 1 - 0
            game.Point(player1); // 2 - 0
            game.Point(player2); // 2 - 1
            game.Point(player1); // 3 - 1
            game.Point(player1); // 4 - 1
            

            Assert.Equal(4, player1.Score._Score);


        }

        [Fact]
        public void Point_AddPointToPlayer2()
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");

            var game = new Game(player1, player2);
            game.Point(player1); // 1 - 0
            game.Point(player1); // 2 - 0
            game.Point(player2); // 2 - 1
            game.Point(player1); // 3 - 1
            game.Point(player1); // 4 - 1

            Assert.Equal(1, player2.Score._Score);

        }

        [Fact]
        public void Point_AddPointToPlayer2WhileSameName()
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Erik");

            var game = new Game(player1, player2);
            game.Point(player1); // 1 - 0
            game.Point(player1); // 2 - 0
            game.Point(player2); // 2 - 1
            game.Point(player1); // 3 - 1
            game.Point(player1); // 4 - 1

            Assert.Equal(4, player1.Score._Score);
        }

        [Fact]
        public void Score_WhenCalled_ShouldReturnScoreForPlayer1()
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");

            var game = new Game(player1, player2);
            game.Point(player1); // 1 - 0
            game.Point(player1); // 2 - 0
            game.Point(player2); // 2 - 1
            game.Point(player1); // 3 - 1
            game.Point(player1); // 4 - 1


            var actualVal = game.Score(player1);

            Assert.Equal(4, actualVal._Score);
            
        }

        [Fact]
        public void Score_WhenCalled_ShouldReturnScoreForPlayer2()
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");

            var game = new Game(player1, player2);
            game.Point(player1); // 1 - 0
            game.Point(player1); // 2 - 0
            game.Point(player2); // 2 - 1
            game.Point(player1); // 3 - 1
            game.Point(player1); // 4 - 1

            var actualVal = game.Score(player2);

            Assert.Equal(1, actualVal._Score);

        }

        [Fact]
        public void Score_ShouldReturnScore0_ForBothPlayer() 
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");

            var game = new Game(player1, player2);


            var actualVal1 = game.Score(player1);
            var actualVal2 = game.Score(player2);

            Assert.Equal(0, actualVal1._Score); 
            Assert.Equal(0, actualVal2._Score); 
        }

        [Fact]
        public void ScoreString_ShouldPrintTheWinnerIsPlayer1()
        {

            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");
            var game = new Game(player1, player2);
            game.Point(player1); // 1 - 0
            game.Point(player1); // 2 - 0
            game.Point(player2); // 2 - 1
            game.Point(player1); // 3 - 1
            game.Point(player1); // 4 - 1


            var actualVal = game.ScoreString();

            Assert.Equal("Player 1 wins", actualVal);


        }

        [Fact]
        public void ScoreString_ShouldPrintTheWinnerIsPlayer2()
        {
            Player player1 = new Player("Erik");
            Player player2 = new Player("Isak");
            var game = new Game(player1, player2);
            game.Point(player2); // 0 - 1 
            game.Point(player2); // 0 - 2 
            game.Point(player1); // 1 - 2     
            game.Point(player2); // 1 - 3 
            game.Point(player2); // 1 - 4 

            var actualVal = game.ScoreString();

            Assert.Equal("Player 2 wins", actualVal);


        }
        
        [Fact]
        public void ScoreString_BothPlayer4Points_GameNotOver()
        {
            var player1 = new Player("Erik");
            player1.Score._Score = 4;

            var player2 = new Player("Isak");
            player2.Score._Score = 4;

            var game = new Game(player1, player2);
            
            var actualVal = game.ScoreString();

            Assert.Equal("The game is not over yet", actualVal);
        }

        [Fact]
        public void ScoreString_DifferentPoint_LessThan4_GameNotOver()
        {
            var player1 = new Player("Erik");
            player1.Score._Score = 1;

            var player2 = new Player("Isak");
            player2.Score._Score = 2;

            var game = new Game(player1, player2);
            game.Point(player1); // 2 - 2 
            game.Point(player2); // 2 - 3 

            var actualVal = game.ScoreString();

            Assert.Equal("The game is not over yet", actualVal);


        }

        [Fact]
        public void ScoreString_IfPointIsOutOfRange()
        {
            var player1 = new Player("Erik");
            player1.Score._Score = 6;

            var player2 = new Player("Isak");
            player2.Score._Score = 4;

            var game = new Game(player1, player2);
            game.Point(player1); // 7 - 4 
            game.Point(player2); // 7 - 5 

            Action act = () => game.ScoreString();
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }



    }
}
