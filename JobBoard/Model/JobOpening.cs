using System.Collections.Generic;

namespace JobBoard.Model
{
  public class JobOpening
  {
    public string Title { get; }
    public string Description { get; }
    public Contact Contact { get; }
    private List<JobOpening> _allOpenings = new List<JobOpening>() { };

    public JobOpening(string title, string description, Contact contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      _allOpenings.Add(this);
    }

    public List<JobOpening> GetAll()
    {
      return _allOpenings;
    }

    public void ClearAll()
    {
      _allOpenings.Clear();
    }
  }
}