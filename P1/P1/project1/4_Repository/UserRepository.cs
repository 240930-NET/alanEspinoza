using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using project1.Data;
using project1.Model;
using project1.Repository.Interface;

namespace project1.Repository;

public class UserRepository : IUserRepository{

    private readonly Project1Context _project1Context;

    public UserRepository(Project1Context project1Context) => _project1Context = project1Context;

    public async Task<List<User>> GetAllUsers(){

        return await _project1Context.Users.ToListAsync();
        
    }

    public async Task<User> AddUser(User user){

        await _project1Context.Users.AddAsync(user);
        await _project1Context.SaveChangesAsync();
        return user;

    }

    public async Task<User> GetUserByUserNameAndPassword(string username, string password){

        User user = await _project1Context.Users.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);
        if(user==null){throw new Exception("Null");}
        else{return user;} 
    }

    public async Task<User> DeleteUserByUserNameAndPassword(User user){

        _project1Context.Remove(user);
        await _project1Context.SaveChangesAsync();
        return user;

    }

    public async Task<User> UpdateUser(User user){

        _project1Context.Update(user);
        await _project1Context.SaveChangesAsync();
        return user;

    }


}