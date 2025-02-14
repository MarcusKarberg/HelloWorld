namespace DIKUCanteen; 
public class Canteen : Room {
    private int cups = 100;

    public int Cups {
        get {
            return cups;
        }
    }

    //Decrease cup count
    public void DecreaseCup() {
        if (cups > 0) {
            cups--;
        }
    }

    // Increase cup count
    public void IncreaseCup() {
        cups += 1;
    }

    // Constructor 1: Access modifier is public. Class name is Canteen. Parameter: string name. (base)name calls the parent room constructor.
    public Canteen(string name) : base(name) {
    }

    // Constructor 2: Access modifier is public. Class name is Canteen. Parameters: string name and int cups. (base)name calls the parent room constructor. 
    public Canteen(string name, int cups) : base(name) {
        this.cups = cups;
    }

    // Override ToString()
    public override string ToString() {
        return $"Canteen: {base.Name}, Available cups: {cups}";
    }
}
