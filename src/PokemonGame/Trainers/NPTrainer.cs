using System;
using System.Collections.Generic;


namespace PokemonGame {
  public class NPTrainer : Trainer {
    public NPTrainer(string name, int animosity) : base(name){
      Animosity = animosity;
    }

    public int Animosity{
      get;
      private set;
    }
  }
}


    