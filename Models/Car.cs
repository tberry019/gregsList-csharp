using System.ComponentModel.DataAnnotations;

namespace gregsList_csharp.Models
{
  public class Car
  {
    public Car(int price, string make, string model, int year, string description, string imgurl)
    {
      Id = Guid.NewGuid().ToString();
      Price = price;
      Make = make;
      Model = model;
      Year = year;
      Description = description;
      ImgUrl = imgurl;
    }
    public string? Id { get; set; }
    [Range(0, int.MaxValue)]

    public string ImgUrl { get; set; }

    public string Description { get; set; }
    public string Model { get; set; }
    [System.ComponentModel.DataAnnotations.Required]
    public int Year { get; set; }
    public int Price { get; set; }
    public string Make { get; set; }
  }
}