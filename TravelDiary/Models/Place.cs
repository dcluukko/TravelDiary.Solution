using System.Collections.Generic;
using System;
namespace TravelDiary.Models
{
  public class Place
  {
    public string Description { get; set; }
    public string Name { get; set; }
    public string Date { get; set; } 

    public int Id { get; }

    private static List<Place> _newPlace = new List<Place> { }; 
    public Place(string description, string name, string date)
    {
      Description = description;
      Name = name;
      Date = date;
      _newPlace.Add(this);
      Id= _newPlace.Count;
    }

    public static List<Place> GetPlace()
    {
      return _newPlace;
    }

    public static Place Find(int searchId)
    {
      return _newPlace[searchId-1];
    }

    // public static 
  }
}