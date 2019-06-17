using System;
using System.Linq;

namespace SafariVacation
{
  class Program
  {
    static void Main(string[] args)
    {

      var db = new SafariVacationContext();


      // db.Animal.Add(new SeenAnimals
      //   {
      //     Species = "Elephant",
      //     CountOfTimesSeen = 3,
      //     LocationOfLastSeen = "Desert"
      //   });
      //   db.SaveChanges();
      //   db.Animal.Add(new SeenAnimals
      //   {
      //     Species = "Lion",
      //     CountOfTimesSeen = 1,
      //     LocationOfLastSeen = "Desert"
      //   });
      //   db.SaveChanges();
      //   db.Animal.Add(new SeenAnimals
      //   {
      //     Species = "Tiger",
      //     CountOfTimesSeen = 5,
      //     LocationOfLastSeen = "Desert"
      //   });
      //   db.SaveChanges();
      //   db.Animal.Add(new SeenAnimals
      //   {
      //     Species = "Bear",
      //     CountOfTimesSeen = 7,
      //     LocationOfLastSeen = "Jungle"
      //   });
      //   db.SaveChanges();
      //   db.Animal.Add(new SeenAnimals
      //   {
      //     Species = "Zebra",
      //     CountOfTimesSeen = 12,
      //     LocationOfLastSeen = "Desert"
      //   });
      //   db.SaveChanges();
      //   db.Animal.Add(new SeenAnimals
      //   {
      //     Species = "Rhino",
      //     CountOfTimesSeen = 9,
      //     LocationOfLastSeen = "desert"
      //   });
      //   db.SaveChanges();

      Console.WriteLine("Let's go on a Safari!");
      Console.WriteLine("Wow you've seen...");


      var alreadySeen = db.Animal.OrderBy(SeenAnimals => SeenAnimals.Species);
      foreach (var SeenAnimals in alreadySeen)
      {
        Console.WriteLine($"{SeenAnimals.Species}");
      }
      Console.WriteLine(":=========================:");

      // var elephant = db.Animal.FirstOrDefault(SeenAnimals => SeenAnimals.Species == "Elephant");
      // elephant.CountOfTimesSeen = elephant.CountOfTimesSeen + 2;
      // db.SaveChanges();

      // var e = db.Animal.FirstOrDefault(SeenAnimals => SeenAnimals.Species == "Elephant");
      // elephant.LocationOfLastSeen = "Sahara";
      // db.SaveChanges();

      var j = db.Animal.Where(SeenAnimals => SeenAnimals.LocationOfLastSeen == "Jungle");
      foreach (var SeenAnimals in j)
      {
        Console.WriteLine($"{SeenAnimals.Species}");
      }

      // var desertAnimals = db.Animal.Where(SeenAnimals => SeenAnimals.LocationOfLastSeen == "Desert");
      // db.Animal.RemoveRange(desertAnimals);
      // db.SaveChanges();


    }
  }
}
