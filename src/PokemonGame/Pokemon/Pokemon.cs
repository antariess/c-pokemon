using System;

namespace PokemonGame {
  public class Pokemon {
    public Pokemon (string sound = "meep", string basicAttackName = "bite", string specialAttackName = "power blast"){
      Attack = 5;
      Health = 20;
      Evade = 0.2;
      Type = "neutral";
      Sound = sound;
      BasicAttackName = basicAttackName;
      SpecialAttackName = specialAttackName;
    }

    public double Attack {
      get;
      internal set;
    }
    public double Evade {
      get;
      internal set;
    }
    public double Health {
      get;
      internal set;
    }
    public string Type {
      get;
      internal set;
    }
    public string BasicAttackName {
      get;
      internal set;
    }
    public string SpecialAttackName {
      get;
      internal set;
    }
    public string Sound {
      get; 
      private set;
    }
  }
}