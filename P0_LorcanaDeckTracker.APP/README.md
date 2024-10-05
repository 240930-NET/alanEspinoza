
<div align="center">

  <h1 style="text-align: center;">P0 Lorcana Deck Tracker</h1>
  <p>By: Alan Espinoza 10/04/2024</p>

</div>

----

### Context

Lorcana is a new Disney based Trading Card Game (TCG) that I recently got into. It features many cool Disnay characters from Disney movies and it's still realeasing many cards.

### Project Statement

I am making a console app using .net applications that will track the deck you are currently building! This deck tracker will help you easily manage your decks by letting you create, edit, save and add decks to your overall desck list.(Disclamer, due to the amount of cards available, there will only be a certain amount of cards that will be implimented to keep this project simple.)

Options Available
 - Create Deck
 - Delete Deck
 - Edit Deck (choose what exactly you want to edit)
 - Save Deck

----

### Deck Rules

Below I will list the rules for my deck building tracker.

- Minimum of 60 cards per deck built.
- Only two different color groupd allowed per deck.
- Can only have up to 4 of each card. 

(Disclamer I will only implement Ruby and Amethyst colors to simplify the project, with around 387 cards implemented in total)

---- 

<div align="center">
    <h1>Project Implementation Draft</h1>
</div>



# Card Class
#### Object class for card

```csharp 
static string cardColor;
//Valid Colors : Amber, Amethyst Emerald, Ruby, Sapphire, and Steel.

static string cardName;
//Valid Names : From validation list.
static boolean cardInkable;

static string cardType;
//Valid Types : Character, Action, Item, Location.

static int cardInkCost;
//Valid Ink Cost : 0 -10. (Inclusive)
```

# Pair Class
```csharp
static int pairAmount;
 //Valid Amount : 1-4. (Inclusive)

 static Card pairName;
 //Valid Name : From validation list.
 ```
 


# Deck Class
#### Object class for deck

```csharp
static string deckName;
//Valid Names : anything.

static List<pairName p> deckCardList;
//Valid Pair : any, pair should have been validated before being able to be created.
```

# Menu Class
#### All user input in this class

```csharp 
static void menuGreet;

static void menuDisplay;

// used to let user choose card he wants to edit
static void menuEditDeckDisplay;

static void menuGetNewDeckDetails;

static void menuGetNewPairDetails;
```

# Validate Class
#### Class for validating input

# Function Class
#### Class to operate all display options!















