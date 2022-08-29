//using System;

//namespace _26thaug
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}

using System;
 
public struct Employee
{

    // Declare three variables
    // id, name and age
    public int Id;
    public string Name;
    public int Age;

    // Set the employee details
    public void SetEmployee(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    // Display employee details
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee:");
        Console.WriteLine("\tId    : " + Id);
        Console.WriteLine("\tName   : " + Name);
        Console.WriteLine("\tAge   : " + Age);
        Console.WriteLine("\n");
    }
}
class GFG
{

    // Driver code
    static void Main(string[] args)
    {

        // Create array of structure
        Employee[] emp = { new Employee(),
                       new Employee(),
                       new Employee() };

        // Pass the array indexes with values as structures
        emp[0].SetEmployee(1, "Ojaswi", 20);
        emp[1].SetEmployee(2, "Rohit", 21);
        emp[2].SetEmployee(3, "Mohit", 23);

        // Call the display method
        emp[0].DisplayEmployee();
        emp[1].DisplayEmployee();
        emp[2].DisplayEmployee();
    }
}