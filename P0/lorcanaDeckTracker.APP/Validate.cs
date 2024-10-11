// keep all my validation functions here
using System;
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

    // public static bool DeckExistsInList(List<Deck> DeckList, string DeckNameCheck){

    //     foreach(Deck d in DeckList){
    //         if(d.getDeckName()==DeckNameCheck){
    //             return true;
    //         }
    //     }
    //     return false;

    // }

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

    public static bool OptionsIsValid(string? option){
        string[] validOptions = {"0","1","2","3","4","5"};
        int pos = Array.IndexOf(validOptions, option);
        if(pos>-1){
            return true;
        }
        return false;
    }

    public static bool OptionIsTrueOrFalse(string? option){
        option = option.ToLower();
        string[] validOptions = {"true", "false"};
        int pos = Array.IndexOf(validOptions, option);
        if(pos>-1){
            return true;
        }
        return false;
    }
    public static bool ColorIsValid(string? color){
        color = color.ToLower();
        string[] validColors = {"amethyst", "emerald", "ruby", "steel", "amber", "sapphire"};
        int pos = Array.IndexOf(validColors, color);
        if(pos>-1){
            return true;
        }
        return false;
    }

    //public static bool CardNameIsValid(string cardName){}
    //need to get card info from online

    public static bool CardTypeIsValid(string? cardType){
        cardType = cardType.ToLower();
        string[] validCardTypes = {"character","action","location","item"};
        int pos = Array.IndexOf(validCardTypes, cardType);
        if(pos>-1){
            return true;
        }
        return false;
    }

    public static bool InkCostValid(string? inkCost){
        string[] validInkCost = {"0","1","2","3","4","5","6","7","8","9","10"};
        int pos = Array.IndexOf(validInkCost, inkCost);
        if(pos>-1){
            return true;
        }
        return false;
    }
    public static bool CardAmountValid(string? cardAmount){
        string[] validCardAmounts = {"1","2","3","4"};
        int pos = Array.IndexOf(validCardAmounts, cardAmount);
        if(pos>-1){
            return true;
        }
        return false;
    }

    public static bool EditOptionsIsValid(string? option){
        string[] validOptions = {"0","1","2","3","4"};
        int pos = Array.IndexOf(validOptions, option);
        if(pos>-1){
            return true;
        }
        return false;
    }
}

