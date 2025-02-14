namespace DIKUArena;
using System;

public class Samnite : Gladiator {
    //Intake is a string parameter. Base(name) calls the constructor parent class: Gladiator
    public Samnite(string name) : base(name) {
        Strength = 6;
        Dodge = 5;
    }

    public override void GetExperience() {
        Strength += 3;
        MaxHealth += 15;
        Dodge += 2;
        DoubleStrike += 5;
        base.GetExperience();
    }
}
