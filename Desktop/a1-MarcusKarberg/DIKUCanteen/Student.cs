namespace DIKUCanteen;
using System.Security.Cryptography;

public class Student : Person {
    public bool HasCup { get; set; } = false;

    //Constructor. Access modifier is public. Parameters are string, string, int. base calls class Person.  
    public Student(string name, string occupation, int age) : base(name, occupation, age) {
    }

    //Take Cup function
    public void TakeCup(Canteen canteen) {
        if (HasCup) {
            Console.WriteLine($"{Name} already has a cup");
            return;
        }

        if (canteen.Cups > 0) {
            canteen.DecreaseCup();
            HasCup = true;
            Console.WriteLine($"{Name} took a cup from {canteen.Name}");
        } else {
            Console.WriteLine($"{Name} can't take a cup, there are no more cups in {canteen.Name}");
        }
    }

    //Return cup function
    public void ReturnCup(Canteen canteen) {
        if (!HasCup) {
            Console.WriteLine($"{Name} has no cup to return");
            return;
        }

        canteen.IncreaseCup();
        HasCup = false;
        Console.WriteLine($"{Name} returned a cup to {canteen.Name}");
    }

    public override string ToString() {
        return base.ToString() + $", Has Cup? {HasCup}";
    }
}
