using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.ViewModels;
using FizzBuzzWeb.ViewModels.Person;

namespace FizzBuzzWeb.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;
        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetAllRecords()
        {
            return _context.Person;

        }
        public IQueryable<Person> TodaysRecords()
        {
            return _context.Person;
        }
    }
}
