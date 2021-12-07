using System;
using Xunit;
using Padel;


namespace PadelTest
{
   public class ScoreTests
    {
       [Fact]
       public void Increase_ShouldIncreaseByOne()
        {
            var score = new Score();
            

            score.Increase();

            Assert.Equal(1, score._Score);

            
        }
    }
}
