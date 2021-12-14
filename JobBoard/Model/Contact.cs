namespace JobBoard.Model
{
  public class Contact
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    Contact(string name, string email, string phone)
    {
      Name = name;
      Email = email;
      Phone = phone;
    }
  }
}