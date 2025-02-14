namespace DIKUCanteen; 
using System;

class Program {
    static void Main(string[] args) {
        // Create a Canteen instance
        Canteen myCanteen = new Canteen("DIKU Cafeteria", 2); // Start with 2 cups

        // Create Students
        Student jason = new Student("Jason", "Student", 22);
        Student frede = new Student("Frede", "Student", 21);
        Student charlie = new Student("Charlie", "Student", 20);

        // Create CanteenBoardMembers
        CanteenBoardMember matty = new CanteenBoardMember("Matty", "Board Member", 24);
        CanteenBoardMember john = new CanteenBoardMember("John", "Board Treasurer", 26);

        // Display initial state
        Console.WriteLine(myCanteen);
        Console.WriteLine($"Starting Cup Budget: {CanteenBoardMember.CupBudget}");

        // Students attempt to take cups
        jason.TakeCup(myCanteen);
        frede.TakeCup(myCanteen);

        // Another student tries but there are no cups left
        charlie.TakeCup(myCanteen);

        // A board member buys more cups
        matty.BuyCup(myCanteen);
        john.BuyCup(myCanteen); // This should fail

        // Charlie tries to take a cup again 
        charlie.TakeCup(myCanteen);

        // Students return their cups
        jason.ReturnCup(myCanteen);
        frede.ReturnCup(myCanteen);
        charlie.ReturnCup(myCanteen);

        // Final state of the canteen. Budget: 960,1. and 4 avaiable cups. 
        Console.WriteLine(myCanteen);
        Console.WriteLine($"Final Cup Budget: {CanteenBoardMember.CupBudget}");
    }
}
