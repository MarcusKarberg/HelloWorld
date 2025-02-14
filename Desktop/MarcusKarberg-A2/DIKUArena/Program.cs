namespace DIKUArena;
using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {

        Arena dIKU = new Arena();

        List<Gladiator> gladiators = new List<Gladiator> {
            new Retiarii("Retiarii1"),
            new Retiarii("Retiarii2"),
            new Retiarii("Retiarii4"),
            new Traex("Traex4"),
            new Samnite("Samnite2"),
            new Traex("Traex1"),
            new Traex("Traex2"),
            new Traex("Traex3"),
            new Samnite("Samnite1"),
            new Traex("Traex5"),
            new Traex("Traex6"),
            new Traex("Traex7"),
            new Retiarii("Retiarii3"),
            new Traex("Traex8"),
            new Traex("Traex9")
        };


        Gladiator champion = dIKU.RunTournament(gladiators);

        Console.WriteLine($"The winner is: {champion.Name}");
    }
}
