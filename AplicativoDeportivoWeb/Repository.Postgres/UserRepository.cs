using System.Globalization;
using AplicativoDeportivoWeb.Domain;
using System.Linq; // se agrega para que funcione el metodo FirstOrDefault de linq
namespace AplicativoDeportivoWeb.Repository.Postgres;
public class UserRepository : IUserRepository
{ 
    public UserRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DataContext DataContext { get; }

    public void AddUser(AplicativoDeportivoWeb.Domain.User user)
    {
        var userDomain = new User()
        {
            Name = user.Name,
            Surname = user.Surname,
            Email = user.Email,
            Password = user.Password,
            DOB = user.DOB.ToUniversalTime(),
            Weight = user.Weight,
            Height = user.Height
        };

        DataContext.Users.Add(userDomain);
        DataContext.SaveChanges();
        
    }
    public User GetUserByEmail(string email)
    {
        return DataContext.Users.FirstOrDefault(u => u.Email == email);
    }
}
