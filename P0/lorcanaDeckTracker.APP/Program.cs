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
        List<Deck> DeckList = new List<Deck>();
        DeckList = Serialize.DeserializeDeckInfo("DeckListData.txt");

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
                    DeckList = Function.CreateDeck(DeckList);
                    break;
                case 3:
                    Function.EditDeck(DeckList);
                    break;
                case 4:
                    Function.DeleteDeck(DeckList);
                    break;
                case 5:
                    Function.SaveDeck(DeckList);
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
