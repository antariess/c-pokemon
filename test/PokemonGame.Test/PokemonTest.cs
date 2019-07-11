using System;
using System.Collections.Generic;
using Xunit;

namespace PokemonGame.Test
{
    public class PokemonInstanceTests
    {
        [Fact]
        public void PokemonInstanceHasCorrectProperties()
        {
            // arrange
            var genericmon = new Pokemon();

            // act

            // assert
            Assert.Equal("neutral", genericmon.Type);
            Assert.Equal(5, genericmon.Attack);
            Assert.Equal(20, genericmon.Health);
            Assert.Equal(0.2, genericmon.Evade);
            Assert.Equal("meep", genericmon.Sound);

        }
    }
}
