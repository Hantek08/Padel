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

        [Fact]
        public void GameList_IsEmpty()
        {
            var set = new Set();
            Assert.Empty(set._Games);
        }
       


        
    }
}
