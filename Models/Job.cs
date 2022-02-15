using System.ComponentModel.DataAnnotations;

namespace gregsList_csharp.Models
{
  public class Job
  {
    public Job(int pay, string position, string company, string time, string location, string imgurl)
    {
      Id = Guid.NewGuid().ToString();
      Pay = pay;
      Position = position;
      Company = company;
      Time = time;
      Location = location;
      ImgUrl = imgurl;
    }
    public string? Id { get; set; }
    [Range(0, int.MaxValue)]

    public string ImgUrl { get; set; }
    [System.ComponentModel.DataAnnotations.Required]
    public int Pay { get; set; }
    public string Position { get; set; }

    public string Company { get; set; }
    public string Time { get; set; }
    public string Location { get; set; }
  }
}