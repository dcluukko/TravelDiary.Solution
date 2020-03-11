using System;
using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;
namespace TravelDiary.Controllers
{
    public class HomeController : Controller
    {
      public int idToEdit = 1;

      [HttpGet("/")]
      public ActionResult Home() { return View(); }

      [HttpGet("place/new")]
      public ActionResult New() { return View(); }

      [HttpGet("/place")] 
      public ActionResult Index() 
      {
      List<Place> newPlace = Place.GetPlace();
      return View(newPlace);
      }
      
      [HttpPost("/place")] 
      public ActionResult Create(string description, string name, string date)
      { 
        Place newPlace = new Place(description, name, date);
        return RedirectToAction("Index"); 
      }

      [HttpPost("/place/{id}")]
      public ActionResult Update(string description, string name, string date)
      {
        Place.Find(idToEdit).Description = description;
        Place.Find(idToEdit).Name = name;
        Place.Find(idToEdit).Date = date;
        return RedirectToAction("Index");
      }

      [HttpGet("/place/{id}/edit")]
      public ActionResult Edit(int id)
      {
        idToEdit = id;
        Place placeToEdit = Place.Find(id);
        return View(placeToEdit);
      }
    }
}
