using System;

namespace PokemonGame {
  public class Battle {
    public Battle(Player player, NPTrainer npc) {
      Player = player;
      NPC = npc;
      Turn = true;
    }

    public bool Turn {
      get;
      private set;
    }

    private Player Player;
    private NPTrainer NPC;

    public void Fight() {
      if (NPC.Animosity > 8) {
        Turn = false;
      }
      do {
        if (Turn) {
          attack(Player.Pocket[0], NPC.Pocket[0]);
        } else {
          attack(NPC.Pocket[0], Player.Pocket[0]);
        }
        Turn = !Turn;
      } while (Player.Pocket[0].Health > 0 || NPC.Pocket[0].Health > 0);
      if(Player.Pocket[0].Health <= 0) {
        Console.WriteLine($"{Player.Pocket[0].Name} has won the fight!! {Player.Name} is victorious!!!");
      } else {
        Console.WriteLine($"{NPC.Pocket[0].Name} has won the fight!! {NPC.Name} is victorious!!!");
      }
    }
    private void attack(Pokemon attacker, Pokemon defender) {
      if(isHit(defender)){
        var damage = damageCalc(attacker);
        defender.Health = defender.Health - damage;
        Console.WriteLine($"{attacker.Name} hits {defender.Name} with {damage}!");
      } else {
        Console.WriteLine($"{attacker.Name} misses!");
      }
    }

    private bool isHit(Pokemon defender) {
      var random = new Random();
      var num = random.Next(1, 101);
      if (defender.Evade > 0.2 && num <= 20) return false;
      if (num <= 10) return false;
      return true;
    }

    private double damageCalc(Pokemon attacker) {
      var random = new Random();
      var num = random.Next(1, 101);
      if (num >= 90) return attacker.Attack * 2;
      return attacker.Attack;
    }
  }
}