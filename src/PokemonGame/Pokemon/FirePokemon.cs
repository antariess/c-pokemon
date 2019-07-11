using System;

namespace PokemonGame {
  public class FirePokemon : Pokemon{
    public FirePokemon(string sound = "roar") : base(sound){
      Name = "Flareon";
      Attack = 7;
      Health = 16;
      Type = "fire";
      BasicAttackName = "scratch";
      SpecialAttackName = "inferno";
    }
  }
}