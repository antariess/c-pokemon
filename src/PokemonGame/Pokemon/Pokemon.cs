using System;

namespace PokemonGame {
  public class Pokemon {
    public Pokemon (string sound = "meep"){
      Attack = 5;
      Health= 20;
      Evade = 0.2;
      Type = "neutral";
      Sound = sound;
    }

    public double Attack;
    public double Health;
    public double Evade;
    public string Type;
    public string Sound {
      get; 
      private set;
    }

  }
}