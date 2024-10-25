using Microsoft.Identity.Client;
using project1.Model;

namespace project1.Repository.Interface;

public interface IUserRepository{

    public Task<List<User>> GetAllUsers();

    public Task<User> GetUserByUserNameAndPassword(string username, string password);

    public Task<User> AddUser(User user);

    // public User UpdateUser(User user);

    public Task<User> DeleteUserByUserNameAndPassword(User user);

    public Task<User> UpdateUser(User user);

}