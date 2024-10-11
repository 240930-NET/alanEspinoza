// Card object class to create and built decks!

public class Card{

    //property that tracks the color the card is
    public string? Color{get;set;}
    //property that tracks card name
    public string? Name{get;set;}
    //property that tracks if the card game is inkable 
    public bool Inkable{get;set;} = false;
    //property that tracks the type of card it is
    public string? Type{get;set;}
    //property that tracks the amount of ink needed to play this card
    public int InkCost{get;set;} = 1;



    public Card(string Color, string Name, bool Inkable, string Type, int InkCost){
        this.Color=Color;
        this.Name=Name;
        this.Inkable=Inkable;
        this.Type=Type;
        this.InkCost=InkCost;
    }

    public Card(){
    }

    public override string ToString(){
        return $"Color group: {Color}\n Card Name: {Name}\n Inkable: {Inkable}\n Type: {Type}\n Ink Cost: {InkCost}\n";
    }

    public string? getCardName(){
        return Name;
    }
}
