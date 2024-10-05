// class to do all display operations 
using ConsoleTables;

public static class Function{

    public static void DisplayDeck(List<Deck> DeckListGiven){
        Console.WriteLine("You are Displaying your Decks!\n");

        var table = new ConsoleTable("0");
        foreach(Deck d in DeckListGiven){
            string name = d.getDeckName();
            table.AddRow($"{name}");
        }
        table.Write(Format.Alternative);
        Console.WriteLine();
    }

    // public override static void DisplayDeck(List<Pair> pList){
    //     foreach(Pair p in pList){
            
    //     }
    // }

    public static void CreateDeck(){
        Console.WriteLine("You Created a Deck!\n");
    }

    public static void DeleteDeck(){
        Console.WriteLine("You Deleted a Deck!\n");
    }
    public static void EditDeck(){
        Console.WriteLine("You Edited a Deck!\n");
    }
    public static void SaveDeck(){
        Console.WriteLine("You Saved all new changes!\n");
    }

}