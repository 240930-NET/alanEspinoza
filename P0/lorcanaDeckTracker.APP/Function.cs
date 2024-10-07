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
        int cc = 0;
        int limit = 60;
        Console.WriteLine("You are creating a Deck!\n");
        do{
        sum = 0;
        Card userCard = Menu.GetUserCardInput();
        Pair userPair = Menu.GetUserPairInput(userCard);
        givenPairList.Add(userPair);
        cc = cc +1;
            foreach(Pair p in givenPairList){
                sum = sum + p.getAmount();
            }
            if(sum>=limit){
                Console.WriteLine("You have reached the minimum card count required."); 
                Console.WriteLine("Do you want to keep adding cards? Are stop here?\n true to keep adding, flase to stop");
                limit = sum;
                limit = Menu.GetUserKeepAddingCardsInput(limit); 
            }
        Console.WriteLine($"You currently have {sum} total amount of cards with {cc} unique cards.");
        }
        while(sum<=limit);
        Deck userDeck = Menu.GetUserDeckInput(givenPairList);
        return userDeck;
    }

    public static void DeleteDeck(List<Deck> DeckList){
        Console.WriteLine("You are Deleting a Deck!\n");

        bool DeckNameReal =false;
        string UserDeckNameDelete;
        Deck DeckDelete = new Deck();
        do{
            UserDeckNameDelete = Menu.GetDeckNameDelete();
            foreach(Deck d in DeckList){
                if(d.getDeckName()==UserDeckNameDelete){
                    DeckNameReal = true;
                    DeckDelete = d;

                }
            }
            //string temp = DeckList.Exists(n => n.Name = UserDeckNameDelete);
            //DeckNameReal = bool.Parse(DeckList.Exists(n => n.Name = UserDeckNameDelete));
            if(!DeckNameReal){
                 Console.WriteLine("\nDeck Name not found in list, try again:");
            }
        }
        while(!DeckNameReal);
        int IndexRemove = DeckList.IndexOf(DeckDelete);
        DeckList.RemoveAt(IndexRemove);
        Console.WriteLine($"\nYou just deleted your {UserDeckNameDelete} deck\n");


    }
    public static void EditDeck(){
        Console.WriteLine("You Edited a Deck!\n");
    }
    public static void SaveDeck(){
        Console.WriteLine("You Saved all new changes!\n");
    }

}