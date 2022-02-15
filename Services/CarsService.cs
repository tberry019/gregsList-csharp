using gregsList_csharp.DB;
using gregsList_csharp.Models;

namespace gregsList_csharp.Services
{

  public class CarsService
  {
    internal List<Car> GetAll()
    {
      return FakeDB.Cars;
    }

    internal Car GetById(string? carId)
    {
      Car? foundCar = FakeDB.Cars.Find(c => c.Id == carId);
      if (foundCar == null)
      {
        throw new Exception("Unable to find care by Id");
      }
      return foundCar;
    }
    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }

    internal Car Delete(string carId)
    {
      Car foundCar = GetById(carId);
      FakeDB.Cars.Remove(foundCar);
      return foundCar;
    }
    internal Car Edit(Car editedCar, string carId)
    {
      Car originalCar = GetById(carId);
      originalCar.Price = editedCar.Price != 0 ? editedCar.Price : originalCar.Price;
      originalCar.Make = editedCar.Make != null ? editedCar.Make : originalCar.Make;
      originalCar.Model = editedCar.Model != null ? editedCar.Model : originalCar.Model;
      originalCar.Year = editedCar.Year != 0 ? editedCar.Year : originalCar.Year;
      originalCar.Description = editedCar.Description != null ? editedCar.Description : originalCar.Description;
      return originalCar;



    }
  }

}