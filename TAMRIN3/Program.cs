//Tamrin 3_Nika Shahbeyk_Shiraz University Of Technology_Student ID: 400213013

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;


//making a Struct for human
public struct Human
{
    //attributes: 5 attribute
    //1.name 
    public String name {get; set;}
    //2.LastName
    public String LastName {get; set;}
    //3.Gender
    public String Gender {get; set;}
    //4.age
    public int age {get; set;}
    //5.height
    public int height {get; set;}
}


class Program
{
    static void Main(String[] args)
    {
        //making a list from human: our List is "human1"
        List<Human> human1 = new List<Human>();

        //making a list from human: our list is "human2"
        List<Human> human2 = new List<Human>();

        //making a list from huamn: our list is "human3"
        List<Human> human3 = new List<Human>();

        //setting values for human1, human2 and human3
        SetValue(human1, 1);
        Console.WriteLine("==================================");
        SetValue(human2, 2);
        Console.WriteLine("==================================");
        SetValue(human3, 3);
        Console.WriteLine("==================================");


        //adding to json File
        Console.WriteLine("==================================");
        Console.WriteLine("((now, we want to add lists to JSON file))");
        string JSON1 = JsonSerializer.Serialize(human1);
        string JSON2 = JsonSerializer.Serialize(human2);
        string JSON3 = JsonSerializer.Serialize(human3);
        try
        {
          File.WriteAllText("human.json", JSON1 + Environment.NewLine + JSON2 + Environment.NewLine + JSON3);
          Console.WriteLine("lists added successfully!");
          Console.WriteLine("==================================");
        }
        catch (Exception e)
        {
            Console.WriteLine("error message: ", e);
        }


        //reading from json File and put them in variables
        Console.WriteLine("==================================");
        Console.WriteLine("((now, we want to read json file and populate the list))");
        string[] lines = File.ReadAllLines("human.json");
        foreach(string line in lines)
        {
            List<Human> human4 = JsonSerializer.Deserialize<List<Human>>(line);
            foreach(Human h in human4)
            {
                Console.WriteLine($"name: {h.name}, Last Name: {h.LastName}, Gender: {h.Gender}, age: {h.age}, height: {h.height}");
            }
        }
        Console.WriteLine("see you again!");
        Console.WriteLine("==================================");
        Console.WriteLine("Press any key to stop!");
        Console.ReadKey();
    }


    static void SetValue(List<Human> huamn, int number)
    {
            Human HUMAN = new Human();
            //message
            Console.WriteLine("Please Enter the Information For Human Number " + number + " : ");
            Console.WriteLine("==================================");
            Console.WriteLine("name: ");
            HUMAN.name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            HUMAN.LastName = Console.ReadLine();
            Console.WriteLine("Gender: ");
            HUMAN.Gender = Console.ReadLine();
            Console.WriteLine("age: ");
            string val;
            val = Console.ReadLine();
            HUMAN.age = Convert.ToInt32(val);
            Console.WriteLine("height: ");
            string val2;
            val2 = Console.ReadLine();
            HUMAN.height = Convert.ToInt32(val2);
            Console.WriteLine("Information for Human Number " + number + " successfully added!");
            huamn.Add(HUMAN);   
    }

}
