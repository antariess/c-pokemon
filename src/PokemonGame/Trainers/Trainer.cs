using System;
using System.Collections.Generic;


namespace PokemonGame {
  public abstract class Trainer {
    public Trainer(string name){
      Name = name;
      Pocket = new List<object>{};
    }

    public string Name {
      get;
      private set;
    }

    public List<object> Pocket {
      get;
      private set;
    }

    public void catchPokemon(Pokemon pokemon){
      Pocket.Add(pokemon);
    }
  }
}