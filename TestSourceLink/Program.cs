using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{

}


[Table("Person")]
public class Person
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}

public class MyDbContext : DbContext
{
    public DbSet<Person> Person { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(local)\SQL2019;Database=master;User ID=sa;Password=Password12!");
    }
}