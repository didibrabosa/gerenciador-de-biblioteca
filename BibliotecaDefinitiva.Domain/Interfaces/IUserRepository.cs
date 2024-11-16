using BibliotecaDefinitiva.Domain.Entities;

namespace BibliotecaDefinitiva.Domain.Entities
{
    public interface IUserRepository 
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}