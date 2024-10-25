namespace project1TEST;

using project1.Repository.Interface;
using project1.Model;
using project1.Model.DTO;
using project1.Service;
using Moq;

public class UserServiceTest
{
    [Fact]
    public async Task GetAllUsersReturnsListWithUserDefaultValues(){
        //arrange
        Mock<IUserRepository> mockRepo = new();
        UserService userService = new(mockRepo.Object);

        List<User> userList = [
            new User {},
        ];

        mockRepo.Setup(repo =>repo.GetAllUsers()).ReturnsAsync(userList);

        //act
        var returnedList = await userService.GetAllUsers();

        //assert
        Assert.Equal(1,returnedList.Count);
        Assert.Contains(returnedList, r => r.FirstName.Equals("John"));
        Assert.Contains(returnedList, r => r.LastName.Equals("Doe"));
        Assert.Contains(returnedList, r => r.UserName.Equals("VeryNotCoolUsername"));
        Assert.Contains(returnedList, r => r.Password.Equals("Password"));

    }

    [Fact]
    public async Task AddUsersDoesWork(){
        //arrange
        Mock<IUserRepository> mockRepo = new();
        UserService userService = new(mockRepo.Object);

        List<User> userList = [
            new User {},
        ];

        User newuser = new(){UserName = "thereallykoolguy", Password="reallykoolpassword"};
        NewUserDTO newuserDTO = new(){UserName = "thereallykoolguy", Password="reallykoolpassword"};

        mockRepo.Setup(repo =>repo.AddUser(It.IsAny<User>())).Callback(()=> userList.Add(newuser)).ReturnsAsync(newuser);

        var result = await userService.AddUser(newuserDTO);

        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Contains(userList, u=> u.Password.Equals("reallykoolpassword"));

    }

    [Theory]
    [InlineData("username1","password1")]
    public async Task GetUserByUsernameAndPassword(string username, string password){

        //arrange
        Mock<IUserRepository> mockRepo = new();
        UserService userService = new(mockRepo.Object);

        List<User> userList = [
            new User { UserName = "username1", Password = "password1"},
        ];

        mockRepo.Setup(repo => repo.GetUserByUserNameAndPassword(username, password))!
            .ReturnsAsync(userList.FirstOrDefault(user => user.UserName == username && user.Password == password));

        var result = await userService.GetUserByUserNameAndPassword(username, password);

        Assert.NotNull(result);
        Assert.Equal(username, result.UserName);
        Assert.Equal(password, result.Password);


    }

    // [Theory]
    // [InlineData("username1","password1")]
    // public async Task DeleteUserByUserNameAndPassword(string username, string password){

    // //arrange
    //     Mock<IUserRepository> mockRepo = new();
    //     UserService userService = new(mockRepo.Object);

    //     List<User> userList = [
    //         new User { UserName = "username1", Password = "password1"},
    //     ];

    //     mockRepo.Setup(repo => repo.GetUserByUserNameAndPassword(username, password))!
    //         .ReturnsAsync(userList.FirstOrDefault(user => user.UserName == username && user.Password == password)).Callback(()=>userList.Remove());

    //     var result = await userService.GetUserByUserNameAndPassword(username, password);

    // }

}