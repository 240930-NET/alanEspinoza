// class for pair object, helps keep track of number of cards in card list inside deck

public class Pair{

    public int Amount{get;set;}
    public Card CardName{get;set;}

    public Pair(int Amount, Card CardName){

        this.Amount = Amount;
        this.CardName = CardName;

    }

    public Pair(){
    }

    public Card getCard(){
        return CardName;
    }

    public int getAmount(){
        return Amount;
    }

}