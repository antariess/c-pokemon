using System;
using System.Collections.Generic;


namespace PokemonGame {
  public class Player : Trainer {
    public Player(string name, string personality):base(name){
      Personality = personality;
    }

    public string Personality{
      get;
      set;
    }
  }
}