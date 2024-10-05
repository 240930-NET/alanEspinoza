// Card object class to create and built decks!

public class Card{

    //property that tracks the color the card is
    public string? cardColor{get;set;}
    //property that tracks card name
    public string? cardName{get;set;}
    //property that tracks if the card game is inkable 
    public bool cardInkable{get;set;}
    //property that tracks the type of card it is
    public string? cardType{get;set;}
    //property that tracks the amount of ink needed to play this card
    public int cardInkCost{get;set;}

}