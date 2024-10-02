/**
Alan Espinoza
10/01/2024
Naive Paper Rock scissors game
**/

class Program{

    public static void Main(string[] args){

        // acceptable entries
        string[] aOptions = {"ROCK", "PAPER", "SCISSORS", "EXIT"};
        var exit = true;

        //greetings
        Console.WriteLine("Hello, and welcome to Rock Papers Scissors");

        //check for exit
        while(exit){
        Console.WriteLine("Go ahead and choose either ROCK, PAPER, or SCISSORS or Type EXIT to quit.");
        string? wordChoice = Console.ReadLine();
        //check entry is accetable
        while(!aOptions.Contains(wordChoice)){
            Console.WriteLine("\nInvalid Entry try again! :)");
            Console.WriteLine("Go ahead and choose either ROCK, PAPER, or SCISSORS or Type EXIT to quit.");
            wordChoice = Console.ReadLine();
        }
        if(wordChoice=="EXIT"){
            exit=false;
            break;    
        }
        Random randomNumGen = new Random();
        int randomIndex = randomNumGen.Next(3);

        string endResult = wordChoice + aOptions[randomIndex];
        Console.WriteLine($"CPU choose {aOptions[randomIndex]}");
        referre(endResult);
        }

    }

    public static void referre(string result){

        if((result=="ROCKROCK")||(result=="PAPERPAPER")||(result=="SCISSORSSCISSORS")){
            Console.WriteLine("Tie \n");    
        }
        else if((result=="ROCKSCISSORS")||(result=="PAPERROCK")||(result=="SCISSORSPAPER")){
            Console.WriteLine("You Win! \n");  
        }
        else {Console.WriteLine("You Loose ;( \n");}
    }

}

