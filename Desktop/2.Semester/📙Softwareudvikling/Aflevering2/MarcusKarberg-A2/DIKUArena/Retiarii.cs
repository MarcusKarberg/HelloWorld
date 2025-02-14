namespace DIKUArena;
using System;

public class Retiarii : Gladiator {
    //Intake is a string parameter. Base(name) calls the constructor parent class: Gladiator
    public Retiarii(string name) : base(name) {
        Dodge = 15;
        Health = 15;
        MaxHealth = 15;
    }

    public override void GetExperience() {
        Strength += 2;
        MaxHealth += 5;
        Dodge += 8;
        DoubleStrike += 5;
        base.GetExperience();
    }
}