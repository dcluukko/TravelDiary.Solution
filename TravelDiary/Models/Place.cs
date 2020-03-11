namespace TravelDiary.Models
{
  public class Place
  {
    public string Description { get; set; }
    public Place(string description)
    {
      Description = description;
    }
  }
}