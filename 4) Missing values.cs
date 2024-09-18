using System;

class Person
{
    // Fields for name, age, and weight
    public string name;
    public int age;
    public double weight;

    // Method to print person details
    public void PrintPerson()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Weight: {weight}");
    }
}

class PersonData
{
    static void Main(string[] args)
    {
        // Create an instance of Person
        Person person = new Person();
        
        // Assign values to the person's properties
        person.name = "Kannan";
        person.age = 19;
        person.weight = 58;

        // Access the PrintPerson method
        person.PrintPerson();
    }
}