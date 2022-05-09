using System;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace TEst
{
  class Program
  {
    static void Main(string[] args)
    {
        var cards = new List<Card>()
        {
          new Card("Handy", "handy",   3, 6, 4),
          new Card("Jock",  "jock",    6, 1, 1),
          new Card("RB-42", "rb-42",   3, 3, 3),
          new Card("JP98",  "jp98",    4, 4, 5),
          new Card("Lilya", "lilya" ,  5, 2, 2)
        };
        WriteCard(cards);
        var result = ReadCard();
    }
    public static void WriteCard(List<Card> card)
    {
      using (Stream stream = new StreamWriter(@"Cards.json", false, Encoding.UTF8).BaseStream)
      {
        JsonWriterOptions t = new JsonWriterOptions();
        t.Indented = true;
        JsonSerializer.Serialize<List<Card>>(new Utf8JsonWriter(stream, t),card);
      }
    }
    public static List<Card> ReadCard()
    {
      using (StreamReader stream = new StreamReader(@"Cards.json",Encoding.UTF8,false))
      {
        var t = stream.ReadToEnd();
        Console.WriteLine(t);
        return JsonSerializer.Deserialize<List<Card>>(t);
      }
    }
  }
}