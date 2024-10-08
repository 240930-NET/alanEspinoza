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

    public static bool DisplayCardListBool(){
        Console.WriteLine("Do you want to display the list of cards from the above deck?\n(true for yes, false for no)");
        bool displayCardsBool = bool.Parse(Console.ReadLine());
        Console.WriteLine("");
        return displayCardsBool;
    }

    public static Card GetUserCardInput(){
        Console.WriteLine("Type in card color:");
        string newCardColor = Console.ReadLine();
        Console.WriteLine("Type in card name:");
        string newCardName = Console.ReadLine();
        Console.WriteLine("Type true if inkable, false if not:");
        bool newCardInkable = bool.Parse(Console.ReadLine());
        Console.WriteLine("Type in card type:");
        string newCardType = Console.ReadLine();
        Console.WriteLine("Type in card ink cost:");
        int newCardInkCost = Int32.Parse(Console.ReadLine());
        Card newCard = new Card(newCardColor, newCardName, newCardInkable, newCardType, newCardInkCost);
        return newCard;
    }

    // since method will be called after getting card info we can use 
    // card returned from previous method
    public static Pair GetUserPairInput(Card newPairCard){
        Console.WriteLine("Type in amount of cards: ");
        int newPairAmount = Int32.Parse(Console.ReadLine());
        //Console.WriteLine("Type in card name: ");
        //string newPairCardName = Console.ReadLine();
        Pair newPair = new Pair(newPairAmount, newPairCard);
        return newPair;
    }

    public static Deck GetUserNewDeckInput(List<Pair> newListPair){
        Console.WriteLine("Type in Deck name: ");
        
        string newDeckName = Console.ReadLine();
        Deck newDeck = new Deck(newDeckName, newListPair);
        return newDeck;
    }

    public static int GetUserKeepAddingCardsInput(int limit){
        bool keepGoing = bool.Parse(Console.ReadLine());
        if(keepGoing)limit = limit+1;
        else limit = 1;
        return limit;
    }

    public static string GetDeckName(){
        Console.WriteLine("Type in the name of the deck:");
        string DeckDeleteName = Console.ReadLine();
        return DeckDeleteName;
    }

    public static void DisplayEditOptions(){
        var table = new ConsoleTable("Pick your edit option from below:");
        table.AddRow("1 : Edit card from card list");
        table.AddRow("2 : Delete card from list");
        table.AddRow("3 : Add card from list");
        table.AddRow("4 : Rename Deck");

        //different format for more asthetic experience
        table.Write(Format.Minimal);
        Console.WriteLine();
    }
    public static string GetPairName(){
        Console.WriteLine("Type in the name of the Card:");
        string CardName = Console.ReadLine();
        return CardName;
    }

}

