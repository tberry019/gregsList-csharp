using System.ComponentModel.DataAnnotations;

namespace gregsList_csharp.Models
{
  public class House
  {
    public House(int price, int bedrooms, int bathrooms, int year, string address, string imgurl)
    {
      Id = Guid.NewGuid().ToString();
      Price = price;
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Year = year;
      Address = address;
      ImgUrl = imgurl;
    }
    public string? Id { get; set; }
    [Range(0, int.MaxValue)]

    public string ImgUrl { get; set; }
    [System.ComponentModel.DataAnnotations.Required]
    public string Address { get; set; }
    public int Bathrooms { get; set; }

    public int Year { get; set; }
    public int Price { get; set; }
    public int Bedrooms { get; set; }
  }
}