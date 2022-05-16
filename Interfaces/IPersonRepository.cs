using FizzBuzzWeb.Models;
using FizzBuzzWeb.ViewModels;
using FizzBuzzWeb.ViewModels.Person;

namespace FizzBuzzWeb.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllRecords();
        IQueryable<Person> TodaysRecords();

    }
}
