using gregsList_csharp.Models;

namespace gregsList_csharp.DB
{
  public class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>()
  {
    new Car(80000, "Tesla", "CyberTruck", 2022, "Under Construction", "" ),
    new Car(1000000, "Bat", "Mobile", 2007, "It Comes in Black", ""),
    new Car(45000, "Chevy", "Camaro", 2006, "Radio doesn't work", "" ),
    new Car(50000, "Dodge", "Charger", 1969, "Those Duke bioys are at it again", ""),
  };

    public static List<House> Houses { get; set; } = new List<House>()
  {
    new House(100000, 1, 1, 1950, "Shack on side of road", "" ),
    new House(200000, 2, 2, 1965, "Lakeridge", "" ),
    new House(300000, 3,3, 1990, "Middle Class address", ""),
    new House(2000000, 4, 5, 2020, "You better be rich",""),
  };


  }
}