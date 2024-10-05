//namespace lorcanaDeckTracker.APP;
class Program
{
    static void Main(string[] args)
    {   
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
                    Function.DisplayDeck();
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
