using System;
using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;
namespace TravelDiary.Controllers
{
    public class HomeController : Controller
    {
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
      public ActionResult Update(int id, string description, string name, string date)
      {
        Place.Find(id).Description = description;
        Place.Find(id).Name = name;
        Place.Find(id).Date = date;
        return RedirectToAction("Index");
      }

      [HttpGet("/place/{id}/edit")]
      public ActionResult Edit(int id)
      {
        Place placeToEdit = Place.Find(id);
        return View(placeToEdit);
      }
    }
}
