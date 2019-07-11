using System;
using Xunit;

namespace PokemonGame.Test {
  public class BattleTests{
    [Fact]
        public void BattleFightsTwoTrainersWithPokemon()
        {
            // arrange
            var brook = new NPTrainer("Brook", 4);
            var misty = new Player("Misty", "bubbly");
            var firemon = new FirePokemon();
            var watermon = new WaterPokemon();

            // act
            brook.catchPokemon(watermon);
            misty.catchPokemon(firemon);

            var battle = new Battle(misty, brook);
            battle.Fight();

            // assert
            
        }  
  }
}