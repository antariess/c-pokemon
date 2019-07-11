using System;
using System.Collections.Generic;
using Xunit;

namespace PokemonGame.Test
{
    public class PlayerInstanceTests
    {
        [Fact]
        public void PlayerInstanceHasCorrectProperties()
        {
            // arrange
            var misty = new Player("Misty", "bubbly");

            // act

            // assert
            Assert.Equal("Misty", misty.Name);
            Assert.Equal("bubbly", misty.Personality);
            Assert.Empty(misty.Pocket);
            Assert.True(misty.Pocket is List<object>);
        }
    }
}
