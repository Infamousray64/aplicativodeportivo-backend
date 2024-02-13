
using System.Security.Cryptography.X509Certificates;
namespace AplicativoDeportivoWeb.Domain;
public class User 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime DOB { get; set; }
    public float Weight { get; set; }
    public float Height { get; set; }

    public User() { }
    
    public void Regristrarse(int Id, string name, string surname, string email, string password, DateTime dob, float weight, float height)
    {
        this.Id = Id;
        this.Name = name;
        this.Surname = surname;
        this.Email = email;
        this.Password = password;
        this.DOB = dob;
        this.Weight = weight;
        this.Height = height;
    }
     }


