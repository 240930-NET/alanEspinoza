using project1.Model;
using project1.Model.DTO;

namespace project1.Service.Interface;

public interface IUserService{

    public Task<List<User>> GetAllUsers();

    public Task<User> AddUser(NewUserDTO user);

    public Task<User> GetUserByUserNameAndPassword(string username, string password);

    public Task<User> DeleteUserByUserNameAndPassword(string username, string password);

    public Task<User> UpdateUser(string username, string password, NewUserDTO user);

}