using System;
using Xunit;
using Padel;

namespace PadelTest
{
    public class SetTests
    {
        [Fact]
        public void GameList_IsNotNull()
        {
            var set = new Set();
            Assert.NotNull(set._Games);
        }
      /*  [Fact]
        public void Point_AddPoint()
        {
            var player1 = new Player("Erik");
            player1.Score._Score = 3;

            var player2 = new Player("Isak");
            player2.Score._Score = 2;
            Set set = new Set();
           
            set.Point(player1);

            Assert.NotEmpty(set._Games);

        }*/

        
    }
}
