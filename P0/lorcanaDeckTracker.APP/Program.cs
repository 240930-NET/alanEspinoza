//Alan Espinoza
//10/04/2024
// Project 0 for 240930 .net training in Revature LLC
// Project 0 : Lorcana Deck Tracker

//namespaces always give me errors need to figure this out
//namespace lorcanaDeckTracker.APP;

class Program
{
    static void Main(string[] args)
    {   
        //Initializing beginning empty list
        List<Pair> Deck0CardList = new List<Pair>();

        //Hardcoding cards, with hardcoded pairs, then adding to deck list
        Card card0 = new Card("Amber", "Rapunzel",false,"Character",5);
        Pair pair0 = new Pair(4, card0);
        Deck0CardList.Add(pair0);

        Card card1 = new Card("Steel", "Doc",true,"Character",3);
        Pair pair1 = new Pair(4,card1);
        Deck0CardList.Add(pair1);

        Deck AmberSteel = new Deck("Agro Amber Steel", Deck0CardList);

        List<Deck> DeckList = new List<Deck>();
        DeckList.Add(AmberSteel);

        //keep track of exiting program or not
        bool exit = true;

        //from menu class, printing greeting line in console
        Menu.Greet();

        //slight pause for dramatic effect
        Thread.Sleep(2000);

        //do while look to get user input until they exit
        do{
            //from menu class, displaying all options
            Menu.DisplayOptions();

            //from menu class, getting user option input
            int userOption = Menu.GetUserOption();

            //switch to do function for whichever option user typed in
            switch(userOption){
                case 1:
                    Function.DisplayDeck(DeckList);
                    break;
                case 2:
                    Function.CreateDeck();
                    break;
                case 3:
                    Function.EditDeck();
                    break;
                case 4:
                    Function.DeleteDeck();
                    break;
                case 5:
                    Function.SaveDeck();
                    break;
                case 0:
                    Menu.Bye();
                    exit = false;
                    break;
            }
        }
        while(exit);


    }
}
