using System;
using System.Collections.Generic;



namespace Collections_Practice
{
    class Program
    {
    static void Main(string[] args)
    {
        
        // Create an array to hold integer values 0 through 9
        int[] arrayOfInts = new int[10]{0,1, 2, 3, 4, 5, 6, 7, 8, 9};
        for (var i=0; i < arrayOfInts.Length; i++){
            arrayOfInts[i] = i;
        }
        foreach(var numbers in arrayOfInts){
            Console.WriteLine(numbers);
        }
        // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        string[] firstNames = new string[4]{ "Tim", "Martin", "Nikki", "Sara"};
        foreach(var names in firstNames){
            Console.WriteLine(names);
        }
        // Create an array of length 10 that alternates between true and false values, starting with true
        bool[] myArray = new bool[10]{true,false,true,false,true,false,true,false,true,false};
        for(var i=0; i < myArray.Length; i++){
            myArray[i] = i%2 ==0;
        }
        // Console.WriteLine(myArray[0]);
        // Console.WriteLine(myArray[1]);
        foreach(var boolean in myArray){
            Console.WriteLine(boolean);
        }
        Random rand = new Random();
        //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        List<string> icecream = new List<string>();    
        icecream.Add("Mint");
        icecream.Add("Chocolate");
        icecream.Add("Vanilla");
        icecream.Add("Rocky");
        icecream.Add("Pistachio");
        //Accessing a generic list value is the same as you would an array
        Console.WriteLine(icecream[2]); 
        Console.WriteLine($"We currently have {icecream.Count} ice cream flavors.");

        icecream.Remove("Vanilla");
        Console.WriteLine($"We currently have {icecream.Count} ice cream flavors.");


        // Create a dictionary that will store both string keys as well as string values
        // Add key/value pairs to this dictionary where:
        // each key is a name from your names array
        // each value is a randomly select a flavor from your flavors list.
        // Loop through the dictionary and print out each user's name and their associated ice cream flavor

        Dictionary<string,string> users = new Dictionary<string, string>();
        for (int i = 0; i < firstNames.Length; i++)
        {
            users.Add(firstNames[i], icecream[rand.Next(icecream.Count)]);
        }
        foreach (KeyValuePair<string,string> entry in users)
        {
            Console.WriteLine(entry.Key + "-" + entry.Value);
        }


    }
    }
}


