// class to do all display operations 
using ConsoleTables;

public static class Function{

    public static void DisplayDeck(List<Deck> DeckListGiven){
        Console.WriteLine("You are Displaying your Decks!\n");

        //var table = new ConsoleTable("Deck List");
        foreach(Deck d in DeckListGiven){
            string name = d.getDeckName();
            var table = new ConsoleTable($"{name}");
            table.Write(Format.Alternative);
            Console.WriteLine();
            bool dCards = Menu.DisplayCardListBool();
            if(dCards) DisplayCardsInDeck(d);
        }
    }

    public static void DisplayCardsInDeck(Deck d){
        string dName = d.getDeckName();
        Console.WriteLine($"You are displaying your Cards from your {dName} deck.");

        var table = new ConsoleTable("Card List");
        List<Pair> cardList = d.getDeckCardList();
        foreach(Pair p in cardList){
            Card cardInfo = p.getCard();
            int cardCount = p.getAmount();
            string cName = cardInfo.getCardName();
            table.AddRow($"{cName} : {cardCount}");
        }
        table.Write();
        Console.WriteLine();
    }

    public static Deck CreateDeck(List<Pair> givenPairList){
        int sum = 0;
        Console.WriteLine("You are creating a Deck!\n");
        do{
        Card userCard = Menu.GetUserCardInput();
        Pair userPair = Menu.GetUserPairInput(userCard);
        givenPairList.Add(userPair);
            foreach(Pair p in givenPairList){
                sum = sum + p.getAmount();
            }
        }
        while(sum<=60);
        Deck userDeck = Menu.GetUserDeckInput(givenPairList);
        return userDeck;
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