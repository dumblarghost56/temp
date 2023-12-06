using Microsoft.EntityFrameworkCore;
using Models;

namespace App;
public class TestContext: DbContext{
  public DbSet<TaskApp> Tasks {get;set;} 
  public DbSet<Category> Categories {get;set;}
  public TestContext(DbContextOptions<TestContext> options) :base (options){}
}
