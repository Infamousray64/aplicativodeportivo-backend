using AplicativoDeportivoWeb.Domain;
namespace AplicativoDeportivoWeb.Repository.Postgres;
internal interface IUserRepository
{
    void AddUser(AplicativoDeportivoWeb.Domain.User user);
    User GetUserByEmail(string email); // se agrega el metodo en la interfaz para que funcione el getuserbyemail en login

}
