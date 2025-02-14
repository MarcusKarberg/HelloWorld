namespace DIKUArena;
using System;
using System.Collections.Generic;

public class Arena {
    public Arena() {
    }

    public Gladiator Battle(Gladiator g1, Gladiator g2) {
        Console.WriteLine("\n⚔️ New Fight ⚔️");
        int round = 1;
        Gladiator current = g1;
        Gladiator inactive = g2;


        while (!g1.HasLost() && !g2.HasLost()) {
            Console.WriteLine($"\n ROUND {round}:");
            current.Attack(inactive);

            if (inactive.HasLost())
                break;


            Gladiator temp = current;
            current = inactive;
            inactive = temp;

            round++;
        }

        Gladiator winner = g1.HasLost() ? g2 : g1;
        Console.WriteLine($"\n \n The winner is: {winner.Name}🫶🫶");

        winner.GetExperience();

        return winner;
    }

    public Gladiator RunTournament(List<Gladiator> competitors) {
        if (competitors.Count < 2) {
            Console.WriteLine("Not enough gladiators");
            return null;
        }

        Console.WriteLine("\n Welcome to DIKU");

        while (competitors.Count > 1) {
            List<Gladiator> winners = new List<Gladiator>();

            for (int i = 0; i < competitors.Count; i += 2) {
                if (i + 1 < competitors.Count) {

                    Gladiator winner = Battle(competitors[i], competitors[i + 1]);
                    winners.Add(winner);
                } else {

                    Console.WriteLine($"\n ⚔️ {competitors[i].Name} advances automatically!");
                    winners.Add(competitors[i]);
                }
            }


            competitors = winners;
        }


        Gladiator tournamentWinner = competitors[0];
        Console.WriteLine($"\n🏆 The Grand CHAMP is: {tournamentWinner.Name}!");
        return tournamentWinner;
    }
}
