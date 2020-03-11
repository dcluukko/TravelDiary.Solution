using System.Collections.Generic;
using System;
namespace TravelDiary.Models
{
  public class Place
  {
    public string Description { get; set; }
    public string Name { get; set; }
    public string Date { get; set; } 

    public static int _currentId = 0;
    public int Id { get; }

    private static List<Place> _newPlace = new List<Place> { }; 
    public Place(string description, string name, string date)
    {
      incrementId();
      Description = description;
      Name = name;
      Date = date;
      _newPlace.Add(this);
      Id= _currentId;
    }
    public static void incrementId()
    {
      _currentId++;
    }

    public static List<Place> GetPlace()
    {
      return _newPlace;
    }

    public static Place Find(int id)
    {
      for (int i = 0; i < _newPlace.Count; i++)
      {
        if (_newPlace[i] is Place)
        {
          if(_newPlace[i].Id == id)
          {
            return _newPlace[i];
          }
        }        
      }
      return null;
    }

    public static void Delete(int id)
    {
      for (int i = 0; i < _newPlace.Count; i++)
      {
        if (_newPlace[i] is Place)
        {
          if(_newPlace[i].Id == id)
          {
            _newPlace.RemoveAt(i);
          }
        }        
      }
    }
  }
}