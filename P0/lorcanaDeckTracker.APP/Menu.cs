// menu class which will have all use input interaction here!

//package to make console output look beter
using ConsoleTables;
public static class Menu{

    //Greeting method to start off
    public static void Greet(){
        
        //making the first row which is also the label/title row
        var table = new ConsoleTable("Welcome to Lorcana Deck Tracker by Alan!");
        //changing format since default show count in table which I don't want
        table.Write(Format.Alternative);
        Console.WriteLine();

    }

    //Method that display all the options the user has
    public static void DisplayOptions(){
        var table = new ConsoleTable("Pick your option from below:");
        table.AddRow("1 : Display all current decks");
        table.AddRow("2 : Create a new deck");
        table.AddRow("3 : Edit a saved deck");
        table.AddRow("4 : Delete a saved deck");
        table.AddRow("5 : Save any changes made to your decks");
        table.AddRow("0 : Exit Lorcana Deck Tracker");

        //different format for more asthetic experience
        table.Write(Format.Minimal);
        Console.WriteLine();
    }

    //Method that asks for user input
    public static int GetUserOption(){
        Console.WriteLine("Type in option from displayed above :");
        int x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("");
        return x;
    }

    //Method to give a good dinal goodbye!
    public static void Bye(){

        var table = new ConsoleTable("Thanks for you support, have a good one!");
        table.Write(Format.Alternative);
        Console.WriteLine();

    }



}

