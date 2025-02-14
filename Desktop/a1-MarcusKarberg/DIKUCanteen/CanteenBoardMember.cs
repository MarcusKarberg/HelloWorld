namespace DIKUCanteen;

public class CanteenBoardMember : Student {
    //Cup budget
    public static float CupBudget = 1;

    //Constructor: Access modifier is public. Parameter: string, string, int. base calls the parent class Student constructor. 
    public CanteenBoardMember(string name, string occupation, int age)
      : base(name, occupation, age) {
    }

    //Buy cups
    public void BuyCup(Canteen canteen) {
        float cupPrice = 1;

        if (CupBudget >= cupPrice) //Cup price
        {
            canteen.IncreaseCup();
            CupBudget -= cupPrice;
            Console.WriteLine($"{Name} bought 1 cup for {canteen.Name}. Budget remaining: {CupBudget}");
        } else {
            Console.WriteLine($"{Name} Can't buy 1 cup. Budget too low. (Remaining is: {CupBudget})");
        }
    }

    public override string ToString() {
        return base.ToString() + "(Canteen Board Member)";
    }
}
