// keep all my validation functions here

public static class Validate{

    public static Deck DeckNameIsReal(List<Deck> DeckList){
        string UserDeckNameCheck;
        bool DeckNameReal = false;
        Deck DeckReturn = new Deck();
        do{
            UserDeckNameCheck = Menu.GetDeckName();
            foreach(Deck d in DeckList){
                if(d.getDeckName()==UserDeckNameCheck){
                    DeckNameReal = true;
                    DeckReturn = d;

                }
            }
            if(!DeckNameReal){
                 Console.WriteLine("\nDeck Name not found in list, try again:");
            }
        }
        while(!DeckNameReal);
        Console.WriteLine("");
        return DeckReturn; 
    }

    public static Pair CardNameIsReal(List<Pair> PairList){
        string UserPairNameCheck;
        bool PairNameReal = false;
        Pair PairReturn = new Pair();
        do{
            UserPairNameCheck = Menu.GetPairName();
            foreach(Pair p in PairList){
                if(p.getCard().Name==UserPairNameCheck){
                    PairNameReal = true;
                    PairReturn = p;

                }
            }
            if(!PairNameReal){
                 Console.WriteLine("\nCard Name not found in list, try again:");
            }
        }
        while(!PairNameReal);
        Console.WriteLine("");
        return PairReturn; 
    }

}

