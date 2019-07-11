using System;

namespace PokemonGame {
  public class WaterPokemon : Pokemon{
    public WaterPokemon(string sound = "blub") : base(sound){
      Evade= 0.4;
      Type = "water";
      BasicAttackName = "slap";
      SpecialAttackName = "tsunami";
    }
  }
}