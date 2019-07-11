using System;
using System.Collections.Generic;
using Xunit;

namespace PokemonGame.Test
{
    public class PokemonInstanceTests
    {
        [Fact]
        public void Pokemon()
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
            Assert.Equal("bite", genericmon.BasicAttackName);
            Assert.Equal("power blast", genericmon.SpecialAttackName);
        }

        [Fact]
        public void FirePokemon()
        {
            // arrange
            var firemon = new FirePokemon();

            // act

            // assert
            Assert.Equal("fire", firemon.Type);
            Assert.Equal(7, firemon.Attack);
            Assert.Equal(16, firemon.Health);
            Assert.Equal(0.2, firemon.Evade);
            Assert.Equal("roar", firemon.Sound);
            Assert.Equal("scratch", firemon.BasicAttackName);
            Assert.Equal("inferno", firemon.SpecialAttackName);
        }

        [Fact]
        public void WaterPokemon()
        {
            // arrange
            var watermon = new WaterPokemon();

            // act

            // assert
            Assert.Equal("water", watermon.Type);
            Assert.Equal(5, watermon.Attack);
            Assert.Equal(20, watermon.Health);
            Assert.Equal(0.4, watermon.Evade);
            Assert.Equal("blub", watermon.Sound);
            Assert.Equal("slap", watermon.BasicAttackName);
            Assert.Equal("tsunami", watermon.SpecialAttackName);
        }

        [Fact]
        public void GrassPokemon()
        {
            // arrange
            var grassmon = new GrassPokemon();

            // act

            // assert
            Assert.Equal("grass", grassmon.Type);
            Assert.Equal(3.5, grassmon.Attack);
            Assert.Equal(23, grassmon.Health);
            Assert.Equal(0.2, grassmon.Evade);
            Assert.Equal("hsss", grassmon.Sound);
            Assert.Equal("kick", grassmon.BasicAttackName);
            Assert.Equal("thunder clap", grassmon.SpecialAttackName);
        }
    }
}
