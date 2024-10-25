namespace project1.Data;

using Microsoft.EntityFrameworkCore;
using project1.Model;

public partial class Project1Context : DbContext{

    public Project1Context(){}
    public Project1Context(DbContextOptions<Project1Context> options) : base(options){}

    public virtual DbSet<User> Users {get; set;}

}