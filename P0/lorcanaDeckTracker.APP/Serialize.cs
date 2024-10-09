// Serialize class to help save and read json file with data
using System;
using System.IO;
using System.Text.Json;

class Serialize{

    public static async Task SerializeDeckInfo(List<Deck> DeckList){

        string DeckListSerialized = JsonSerializer.Serialize(DeckList);

        try{
            using(StreamWriter writer = File.CreateText("DeckListData.txt")){
                await writer.WriteAsync(DeckListSerialized);
            }
        }
        catch(Exception ex){
            Console.WriteLine($"Could not save:{ex.Message}");
        }

    }

    public static List<Deck> DeserializeDeckInfo(string FileName){

        if(File.Exists(FileName)){
            try{
                using(StreamReader reader = File.OpenText("DeckListData.txt")){
                    string DeckListJson = reader.ReadToEnd();
                    return JsonSerializer.Deserialize<List<Deck>>(DeckListJson);
                }
            }
            catch(Exception ex){
                Console.WriteLine($"Could not load saved decklist:{ex.Message}");
                return new List<Deck>();
            }
        }
        else{
            using (File.Create(FileName));
            
            return new List<Deck>();
        }

    }



}
