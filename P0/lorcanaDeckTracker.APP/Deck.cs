//deck class that makes deck object

public class Deck{

    //property tracking the decks name
    public string Name{get;set;} = "default name";

    //property keeping track of list holding list of card in deck
    public List<Pair> ListName{get;set;} = new List<Pair>();

    public Deck(string Name, List<Pair> ListName){
        this.Name = Name;
        this.ListName = ListName;
    }

    public Deck(string Name){
        this.Name = Name;
        this.ListName = new List<Pair>();
    } 

    public Deck(){
    }

    public string getDeckName(){
        return this.Name;
    }

    public List<Pair> getDeckCardList(){
        return this.ListName;
    }

}