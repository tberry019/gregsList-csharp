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
      Job? foundJob = FakeDB.Jobs.Find(j => j.Id == jobId);
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
      originalJob.Pay = editedJob.Pay != 0 ? editedJob.Pay : originalJob.Pay;
      originalJob.Position = editedJob.Position != null ? editedJob.Position : originalJob.Position;
      originalJob.Company = editedJob.Company != null ? editedJob.Company : originalJob.Company;
      originalJob.Time = editedJob.Time != null ? editedJob.Time : originalJob.Time;
      originalJob.Location = editedJob.Location != null ? editedJob.Location : originalJob.Location;
      originalJob.ImgUrl = editedJob.ImgUrl != null ? editedJob.ImgUrl : originalJob.ImgUrl;

      return originalJob;



    }
  }
}