//deck class that makes deck object

public class Deck{

    //property tracking the decks name
    public string? Name{get;set;} 

    //property keeping track of list holding list of card in deck
    public List<Pair> ListName{get;set;}

    public Deck(string Name, List<Pair> ListName){
        this.Name = Name;
        this.ListName = ListName;
    } 

    public string getDeckName(){
        return this.Name;
    }

    public List<Pair> getDeckCardList(){
        return this.ListName;
    }

}