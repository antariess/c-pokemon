using System;
using System.Collections.Generic;


namespace PokemonGame {
  public abstract class Trainer {
    public Trainer(string name){
      Name = name;
      Pocket = new List<Pokemon>{};
    }

    public string Name {
      get;
      private set;
    }

    public List<Pokemon> Pocket {
      get;
      private set;
    }

    public void catchPokemon(Pokemon pokemon){
      Pocket.Add(pokemon);
    }
  }
}