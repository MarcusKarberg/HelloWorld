namespace DIKUCanteen;

public class Person {
    public string Name {
        get;
    }
    public string Occupation {
        get;
    }
    public int Age {
        get;
    }

    //Constructor: Access modifier is public. Name, Age, Occupation. Parameter: string, string, int. 
    public Person(string name, string occupation, int age) {
        Name = name;
        Occupation = occupation;
        Age = age;
    }

    //Override tostring()
    public override string ToString() {
        {
            return $"Name: {Name}, Occupation: {Occupation}, Age: {Age}";
        }
    }
}
