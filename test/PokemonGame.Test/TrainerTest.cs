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
            var firemon = new FirePokemon();

            // act

            // assert
            Assert.Equal("Misty", misty.Name);
            Assert.Equal("bubbly", misty.Personality);
            Assert.True(misty.Pocket is List<Pokemon>);
            Assert.Empty(misty.Pocket);
        }

        [Fact]
        public void PlayerInstanceHasCorrectMethods()
        {
            // arrange
            var misty = new Player("Misty", "bubbly");
            var firemon = new FirePokemon();

            // act
            misty.catchPokemon(firemon);

            // assert
            Assert.Same(firemon, misty.Pocket[0]);
        }  

        [Fact]
        public void NPTrainerInstanceHasCorrectMethods()
        {
            // arrange
            var brook = new NPTrainer("Brook", 4);
            var watermon = new WaterPokemon();

            // act
            brook.catchPokemon(watermon);

            // assert
            Assert.Equal(4, brook.Animosity);
            Assert.Same(watermon, brook.Pocket[0]);
        }          
    }
}
