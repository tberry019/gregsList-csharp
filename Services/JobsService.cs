using gregsList_csharp.DB;
using gregsList_csharp.Models;


namespace gregsList_csharp.Services
{
  public class JobsService
  {
    internal List<Job> GetAll()
    {
      return FakeDB.Jobs;
    }

    internal Job GetById(string? jobId)
    {
      Job? foundHouse = FakeDB.Jobs.Find(j => j.Id == jobId);
      if (foundJob == null)
      {
        throw new Exception("Unable to find job by Id");
      }
      return foundJob;
    }
    internal Job Create(Job newJob)
    {
      FakeDB.Jobs.Add(newJob);
      return newJob;
    }

    internal Job Delete(string jobId)
    {
      Job foundJob = GetById(jobId);
      FakeDB.Jobs.Remove(foundJob);
      return foundJob;
    }
    internal Job Edit(Job editedJob, string jobId)
    {
      Job originalJob = GetById(jobId);
      originalJob.Price = editedJob.Price != 0 ? editedJob.Price : originalJob.Price;
      originalJob.Bedrooms = editedJob.Bedrooms != 0 ? editedJob.Bedrooms : originalJob.Bedrooms;
      originalJob.Bathrooms = editedJob.Bathrooms != 0 ? editedJob.Bathrooms : originalJob.Bathrooms;
      originalJob.Year = editedJob.Year != 0 ? editedJob.Year : originalJob.Year;
      originalJob.Address = editedJob.Address != null ? editedJob.Address : originalJob.Address;
      originalJob.ImgUrl = editedJob.ImgUrl != null ? editedJob.ImgUrl : originalJob.ImgUrl;

      return originalJob;



    }
  }
}