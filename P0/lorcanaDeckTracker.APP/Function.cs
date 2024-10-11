// class to do all display operations 
using ConsoleTables;

public static class Function{

    public static void DisplayDeck(List<Deck> DeckListGiven){
        Console.WriteLine("You are Displaying your Decks!\n");

        //var table = new ConsoleTable("Deck List");
        foreach(Deck d in DeckListGiven){
            var table = new ConsoleTable($"{d.Name}");
            table.Write(Format.Alternative);
            Console.WriteLine();
            bool dCards = Menu.DisplayCardListBool();
            if(dCards) DisplayCardsInDeck(d);
        }
    }

    public static void DisplayCardsInDeck(Deck d){
        Console.WriteLine($"You are displaying your Cards from your {d.Name} deck.");

        var table = new ConsoleTable("Card Name",  "Amount" , "Card Color", "Inkability", "Card Type", "Ink Cost");
        List<Pair> cardList = d.getDeckCardList();
        foreach(Pair p in cardList){
            table.AddRow($"{p.CardName.Name}", $"{p.Amount}", $"{p.CardName.Color}", $"{p.CardName.Inkable}", $"{p.CardName.Type}", $"{p.CardName.InkCost}" );
        }
        table.Write();
        Console.WriteLine();
    }

    public static List<Deck> CreateDeck(List<Deck> DeckList){
        List<Pair> givenPairList = new List<Pair>();
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
        Deck userDeck = Menu.GetUserNewDeckInput(givenPairList);
        DeckList.Add(userDeck);
        return DeckList;
    }

    public static void DeleteDeck(List<Deck> DeckList){
        Console.WriteLine("You are Deleting a Deck!\n");

        Deck DeckDelete = new Deck();
        DeckDelete = Validate.DeckNameIsReal(DeckList);

        int IndexRemove = DeckList.IndexOf(DeckDelete);
        DeckList.RemoveAt(IndexRemove);
        Console.WriteLine($"\nYou just deleted your {DeckDelete.getDeckName()} deck\n");

    }
    public static void EditDeck(List<Deck> DeckList){
        int option;
        Pair PairEdit = new Pair();
        Pair PairNew = new Pair();
        Card CardNew = new Card();
        Console.WriteLine("You are Editing a Deck!\n");

        Deck DeckEdit = new Deck();
        DeckEdit = Validate.DeckNameIsReal(DeckList);
        Menu.DisplayEditOptions();
        option = Menu.GetUserOption();

        switch(option){
            case 1:
                PairEdit = Validate.CardNameIsReal(DeckEdit.ListName);
                PairNew = Menu.GetUserPairInput(PairEdit.CardName!);
                DeckEdit.ListName.Remove(PairEdit);
                DeckEdit.ListName.Add(PairNew);
                //PairEdit = PairNew;
                break;
            case 2:
                int sum = 0;
                PairEdit = Validate.CardNameIsReal(DeckEdit.ListName);
                DeckEdit.ListName.Remove(PairEdit);
                foreach(Pair p in DeckEdit.ListName){
                    sum = sum + p.getAmount();
                }
                while(sum<60){
                    CardNew = Menu.GetUserCardInput();
                    PairNew = Menu.GetUserPairInput(CardNew);
                    DeckEdit.ListName.Add(PairNew);
                    sum = sum+PairNew.Amount;
                }
                break;
            case 3:
                CardNew = Menu.GetUserCardInput();
                PairNew = Menu.GetUserPairInput(CardNew);
                DeckEdit.ListName.Add(PairNew);
                break;
            case 4:
                string? newDeckName = Menu.GetDeckName();
                DeckEdit.Name = newDeckName;
                break;
            case 0:
                break;
        }

    }
    public static async void SaveDeck(List<Deck> DeckList){
        Console.WriteLine("You Saved all new changes!\n");
        await Serialize.SerializeDeckInfo(DeckList);
    }

}