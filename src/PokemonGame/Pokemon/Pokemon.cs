using System;

namespace PokemonGame {
  public class Pokemon {
    public Pokemon (string sound = "meep", string basicAttackName = "bite", string specialAttackName = "power blast"){
      Name = "Eevee";
      Attack = 5;
      Health = 20;
      Evade = 0.2;
      Type = "neutral";
      Sound = sound;
      BasicAttackName = basicAttackName;
      SpecialAttackName = specialAttackName;
    }

    public string Name{
      get;
      protected set;
    }

    public double Attack {
      get;
      protected set;
    }
    public double Evade {
      get;
      protected set;
    }
    public double Health {
      get;
      internal set;
    }
    public string Type {
      get;
      protected set;
    }
    public string BasicAttackName {
      get;
      protected set;
    }
    public string SpecialAttackName {
      get;
      protected set;
    }
    public string Sound {
      get; 
      protected set;
    }
  }
}