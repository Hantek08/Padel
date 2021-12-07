using System;
using Xunit;
using Padel;


namespace PadelTest
{
    public class PlayerTests
    {
        [Fact]
        public void Player_PlayerIsNotNull()
        {
            var player = new Player("Erik");

            Assert.NotNull(player);

        }

        [Fact]
        public void Player_PlayerNameIsNotEmpty()
        {
            var player = new Player("Erik");
            Assert.NotEmpty(player.Name);

        }

        [Fact]
        public void Player_PlayerNameIsEmpty()
        {
            Action act = () => new Player("");
            Assert.Throws<ArgumentException>(act);

        }

        [Fact]
        public void Score_IsNotNull()
        {
            var player = new Player("Erik");

            Assert.NotNull(player.Score);

        }

        [Fact]
        public void Point_ShouldIncreaseByOne_Return1()
        {
            var player = new Player("Erik");

            player.Point();

            Assert.Equal(1, player.Score._Score);


        }

        [Fact]
        public void Point_ShouldIncreaseByOne_Return3()
        {
            var player = new Player("Erik");
            player.Score._Score = 2;

            player.Point();

            Assert.Equal(3, player.Score._Score);


        }
    }
}
