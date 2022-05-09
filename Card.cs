using System;
using System.Text.Json;

namespace TEst
{
  [Serializable()]
  public class Card
  {
    public Card(string name, string path,int health, int damage, int energy)
    {
      Name = name;
      Health = health;
      Damage = damage;
      Path = path;
      Energy = energy;
    }
    public string Name { get; set; }
    public string Path { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Energy { get; set; }
    
    // public Action SomeAction { get; set; }
  }
}