namespace DIKUArena;
using System;

public class Traex : Gladiator {
    //Intake is a string parameter. Base(name) calls the constructor parent class: Gladiator
    public Traex(string name) : base(name) {
        Health = 30;
        MaxHealth = 30;
        DoubleStrike = 15;
    }

    public override void GetExperience() {
        Strength += 2;
        MaxHealth += 10;
        Dodge += 5;
        DoubleStrike += 8;
        base.GetExperience();
    }
}
