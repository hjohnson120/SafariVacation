using System;
using System.Linq;


namespace SafariVacation
{
  public class AnimalsAdded
  {

    static void Main(string[] args)
    {
      var db = new SafariVacationContext();

      db.Animal.Add(new SeenAnimals
      {
        Species = "Elephant",
        CountOfTimesSeen = 3,
        LocationOfLastSeen = "Desert"
      });
      db.SaveChanges();
      db.Animal.Add(new SeenAnimals
      {
        Species = "Lion",
        CountOfTimesSeen = 1,
        LocationOfLastSeen = "Desert"
      });
      db.SaveChanges();
      db.Animal.Add(new SeenAnimals
      {
        Species = "Tiger",
        CountOfTimesSeen = 5,
        LocationOfLastSeen = "Desert"
      });
      db.SaveChanges();
      db.Animal.Add(new SeenAnimals
      {
        Species = "Bear",
        CountOfTimesSeen = 7,
        LocationOfLastSeen = "Jungle"
      });
      db.SaveChanges();
      db.Animal.Add(new SeenAnimals
      {
        Species = "Zebra",
        CountOfTimesSeen = 12,
        LocationOfLastSeen = "Desert"
      });
      db.SaveChanges();
      db.Animal.Add(new SeenAnimals
      {
        Species = "Rhino",
        CountOfTimesSeen = 9,
        LocationOfLastSeen = "desert"
      });
      db.SaveChanges();
    }
  }
}