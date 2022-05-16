using System;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.Pages;
using FizzBuzzWeb.ViewModels;
using FizzBuzzWeb.ViewModels.Person;
using FizzBuzzWeb.Data;

namespace FizzBuzzWeb.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;
        private readonly PeopleContext _peopleContext;
        public PersonService(IPersonRepository personRepo, PeopleContext peopleContext)
        {
            _personRepo = personRepo;
            _peopleContext = peopleContext;
        }
        public void AddEntry(PersonForListVM person)
        {
            string[] words = person.FullName.Split(' ');
            Person personDb = new()
            {
                Id = person.Id,
                FirstName = words[0],
                LastName = words[1],
                Year = person.Year,
                localDate = person.localDate
            };
            personDb.ActualTime();
            _peopleContext.Person.Add(personDb);
            _peopleContext.SaveChanges();
        }
        public ListPersonForListVM GetAllEntries()
        {
            var people = _personRepo.GetAllRecords();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                var pVM = new PersonForListVM()
                {
                    Id = person.Id,
                    FullName = person.FirstName + " " + person.LastName,
                    Year = person.Year,
                    localDate = person.localDate
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }
        public ListPersonForListVM GetEntriesFromToday()
        {
            var people = _personRepo.TodaysRecords();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                if (person?.localDate?.Date == DateTime.Now.Date)
                {
                    var pVM = new PersonForListVM()
                    {
                        Id = person.Id,
                        FullName = person.FirstName + " " + person.LastName,
                        Year = person.Year,
                        localDate = person.localDate
                    };
                    result.People.Add(pVM);
                }
            }
            result.Count = result.People.Count;
            return result;
        }

    }
}
