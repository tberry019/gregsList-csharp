using gregsList_csharp.DB;
using gregsList_csharp.Models;

namespace gregsList_csharp.Services
{
  public class HousesService
  {
    internal List<House> GetAll()
    {
      return FakeDB.Houses;
    }

    internal House GetById(string? houseId)
    {
      House? foundHouse = FakeDB.Houses.Find(h => h.Id == houseId);
      if (foundHouse == null)
      {
        throw new Exception("Unable to find house by Id");
      }
      return foundHouse;
    }
    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }

    internal House Delete(string houseId)
    {
      House foundHouse = GetById(houseId);
      FakeDB.Houses.Remove(foundHouse);
      return foundHouse;
    }
    internal House Edit(House editedHouse, string houseId)
    {
      House originalHouse = GetById(houseId);
      originalHouse.Price = editedHouse.Price != 0 ? editedHouse.Price : originalHouse.Price;
      originalHouse.Bedrooms = editedHouse.Bedrooms != 0 ? editedHouse.Bedrooms : originalHouse.Bedrooms;
      originalHouse.Bathrooms = editedHouse.Bathrooms != 0 ? editedHouse.Bathrooms : originalHouse.Bathrooms;
      originalHouse.Year = editedHouse.Year != 0 ? editedHouse.Year : originalHouse.Year;
      originalHouse.Address = editedHouse.Address != null ? editedHouse.Address : originalHouse.Address;
      originalHouse.ImgUrl = editedHouse.ImgUrl != null ? editedHouse.ImgUrl : originalHouse.ImgUrl;

      return originalHouse;



    }
  }
}