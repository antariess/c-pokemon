using System;

namespace PokemonGame {
  public class GrassPokemon : Pokemon{
    public GrassPokemon(string sound = "hsss") : base(sound){
      Name = "Leafeon";
      Attack = 3.5;
      Health = 23;
      Type = "grass";
      BasicAttackName = "kick";
      SpecialAttackName = "thunder clap";
    }
  }
}