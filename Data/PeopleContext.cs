using FizzBuzzWeb.Models;
using FizzBuzzWeb.ViewModels;
using FizzBuzzWeb.ViewModels.Person;

using Microsoft.EntityFrameworkCore;

namespace FizzBuzzWeb.Data
{
    public class PeopleContext : DbContext
    {

        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; } = null!;
    }
}
