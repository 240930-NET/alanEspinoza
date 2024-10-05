// menu class which will have all use input interaction here!
using ConsoleTables;
public static class Menu{

    public static void Greet(){
        
        var table = new ConsoleTable("Welcome to Lorcana Deck Tracker by Alan!");
        table.Write(Format.Alternative);
        Console.WriteLine();

    }

    public static void DisplayOptions(){
        var table = new ConsoleTable("Pick your option from below:");
        table.AddRow("1 : Display all current decks");
        table.AddRow("2 : Create a new deck");
        table.AddRow("3 : Edit a saved deck");
        table.AddRow("4 : Delete a saved deck");
        table.AddRow("5 : Save any changes made to your decks");
        table.AddRow("0 : Exit Lorcana Deck Tracker");

        table.Write(Format.Minimal);
        Console.WriteLine();
    }

    public static int GetUserOption(){
        Console.WriteLine("Type in option from displayed above :");
        int x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("");
        return x;
    }

    public static void Bye(){

        var table = new ConsoleTable("Thanks for you support, have a good one!");
        table.Write(Format.Alternative);
        Console.WriteLine();

    }



}

