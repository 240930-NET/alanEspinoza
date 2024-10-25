using project1.Model;
using project1.Model.DTO;
using project1.Repository.Interface;
using project1.Service.Interface;

namespace project1.Service;

public class UserService : IUserService{

    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository) => _userRepository = userRepository;    

    public async Task<List<User>> GetAllUsers(){

        return await _userRepository.GetAllUsers();

    }

    DateTime LocalDate = DateTime.Now;

    public async Task<User> AddUser(NewUserDTO userDTO){

        User user =new(){
            FirstName = userDTO.FirstName,
            LastName = userDTO.LastName,
            UserName = userDTO.UserName,
            Password = userDTO.Password,
            DateUserCreated = DateOnly.FromDateTime(LocalDate),
            TimeUserCreated = TimeOnly.FromDateTime(LocalDate),
            LatestDateUserLogin = DateOnly.FromDateTime(LocalDate),
            LatestTimeUserLogin = TimeOnly.FromDateTime(LocalDate)
        };

        // User userDup =  await GetUserByUserNameAndPassword(userDTO.UserName, userDTO.Password);
        // if(userDup ==null){
        //     throw new Exception("User Name and password taken");
        // }

        if(user.UserName ==null){
            throw new Exception("User Name is required");
        }
        if(user.Password == null){
            throw new Exception("Password is required");
        }
        else{
            await _userRepository.AddUser(user);
        }

        return user;

    }

    public async Task<User> GetUserByUserNameAndPassword(string username, string password){

        User SearchedUser = await _userRepository.GetUserByUserNameAndPassword(username, password);
        if (SearchedUser ==null){
            throw new Exception($"No user found with these credentials\nUsername: {username}\nPassword: {password}");
        }
        else{
            SearchedUser.LatestDateUserLogin = DateOnly.FromDateTime(LocalDate);
            SearchedUser.LatestTimeUserLogin = TimeOnly.FromDateTime(LocalDate);
            await _userRepository.UpdateUser(SearchedUser);
            return SearchedUser;
        }
    }

    public async Task<User> DeleteUserByUserNameAndPassword(string username, string password){

        User SearchedUser = await _userRepository.GetUserByUserNameAndPassword(username, password);
        if(SearchedUser == null){
            throw new Exception($"No user found with these credentials\nUsername: {username}\nPassword: {password}");
        }
        else{
            await _userRepository.DeleteUserByUserNameAndPassword(SearchedUser);
            return SearchedUser;
        }
    }

    public async Task<User> UpdateUser(string username, string password, NewUserDTO user){

        User SearchedUser = await _userRepository.GetUserByUserNameAndPassword(username, password);
        if(SearchedUser == null){
            throw new Exception($"No user found with these credentials\nUsername: {username}\nPassword: {password}");
        }
        else{
            SearchedUser.FirstName = user.FirstName;
            SearchedUser.LastName = user.LastName;
            SearchedUser.UserName = user.UserName;
            SearchedUser.Password = user.Password;
            SearchedUser.LatestDateUserLogin = DateOnly.FromDateTime(LocalDate);
            SearchedUser.LatestTimeUserLogin = TimeOnly.FromDateTime(LocalDate);
            await _userRepository.UpdateUser(SearchedUser);
            return SearchedUser;
        }
    }

}