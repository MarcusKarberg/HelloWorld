namespace DIKUArena;
using System;

public class Gladiator {
    // Private fields
    private string name;
    private int level;
    private int health;
    private int maxHealth;
    private int strength;
    private int dodge;
    private int doubleStrike;
    private Random rand = new Random();

    // Public properties
    public string Name => name;
    public int Level => level;

    public int MaxHealth {
        get => maxHealth;
        protected set => maxHealth = Math.Max(value, 1);
    }
    public int Strength {
        get => strength;
        protected set => strength = Math.Max(value, 1);
    }
    public int Dodge {
        get => dodge;
        protected set => dodge = Math.Min(value, 60);
    }
    public int DoubleStrike {
        get => doubleStrike;
        protected set => doubleStrike = Math.Min(value, 60);
    }

    public int Health {
        get => health;
        protected set => health = Math.Clamp(value, 0, MaxHealth);
    }

    // Constructor
    // Initalizes a gladiator object. 
    // The access modifier is public and the constructor is named Gladiator.
    // Input parameter is a string (name).
    public Gladiator(string name) {
        this.name = name;
        this.level = 1;
        this.maxHealth = 20;
        this.health = 20;
        this.strength = 4;
        this.dodge = 10;
        this.doubleStrike = 10;
    }

    // ToString Override
    public override string ToString() {
        return $"Gladiator: {name} | Level: {level} | Health: {health}";
    }

    public bool HasLost() {
        return health <= 0;
    }

    public bool LoseHealth(int strength) {
        int randomValue = rand.Next(101);
        if (Dodge > randomValue) {
            return false;
        } else {
            Health -= strength;
            Console.WriteLine($"{Name} took {strength} damage. Remaining health: {Health}");
            return true;
        }
    }

    // Attack an opponent
    public void Attack(Gladiator opponent) {
        int randomValue = rand.Next(101);
        int attackDamage;

        if (DoubleStrike > randomValue) {
            attackDamage = Strength * 2;
            Console.WriteLine($"DOUBLESTRIKE! {Name} attempts to hit {opponent.Name} with {attackDamage} points of damage.");
        } else {
            attackDamage = Strength;
            Console.WriteLine($"{Name} attacks {opponent.Name} with {attackDamage} points of damage.");
        }

        bool attackLanded = opponent.LoseHealth(attackDamage);

        if (!attackLanded) {
            Console.WriteLine($"But {opponent.Name} dodged the attack!");
        }
    }


    // Level up
    public virtual void GetExperience() {
        level++;
        Health = MaxHealth; // Restore health upon leveling up
        Console.WriteLine($"{name} is now level {level}.");
        Console.WriteLine($"Strength: {Strength}, MaxHealth: {MaxHealth},");
        Console.WriteLine($"Chance of dodging: {Dodge}%, Chance of doubleStrike: {DoubleStrike}%");
    }
}
