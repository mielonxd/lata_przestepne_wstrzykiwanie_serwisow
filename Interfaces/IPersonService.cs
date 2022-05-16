using FizzBuzzWeb.ViewModels;
using FizzBuzzWeb.ViewModels.Person;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Interfaces
{
    public interface IPersonService
    {
        public void AddEntry(PersonForListVM person);
        ListPersonForListVM GetAllEntries();
        ListPersonForListVM GetEntriesFromToday();

    }
}
