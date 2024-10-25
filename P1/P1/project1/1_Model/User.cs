namespace project1.Model;

//using System;

public class User{

    //DateTime LocalDate = DateTime.Now;

    public int Id { get; set;}
    public string FirstName {get; set;} = "John";
    public string LastName {get; set;} = "Doe";
    public string UserName {get; set;} = "VeryNotCoolUsername";
    public string Password {get; set;} = "Password";
    public DateOnly DateUserCreated {get;set;}
    public TimeOnly TimeUserCreated {get; set;}
    public DateOnly LatestDateUserLogin {get; set;}
    public TimeOnly LatestTimeUserLogin {get; set;}

}