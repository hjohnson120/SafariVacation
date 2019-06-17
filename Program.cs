using System;
using System.Linq;

namespace SafariVacation
{
  class Program
  {
    static void Main(string[] args)
    {

      var db = new SafariVacationContext();

      Console.WriteLine("Let's go on a Safari!");
      Console.WriteLine("Wow you've seen...");


      var alreadySeen = db.Animal.OrderBy(SeenAnimals => SeenAnimals.Species);
      foreach (var SeenAnimals in alreadySeen)
      {
        Console.WriteLine($"{SeenAnimals.Species}");
      }
      Console.WriteLine(":=========================:");

      var elephant = db.Animal.FirstOrDefault(SeenAnimals => SeenAnimals.Species == "Elephant");
      elephant.CountOfTimesSeen = elephant.CountOfTimesSeen + 2;
      db.SaveChanges();

      var e = db.Animal.FirstOrDefault(SeenAnimals => SeenAnimals.Species == "Elephant");
      elephant.LocationOfLastSeen = elephant.LocationOfLastSeen + "Sahara";
      db.SaveChanges();


    }
  }
}
