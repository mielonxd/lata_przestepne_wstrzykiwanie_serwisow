using FizzBuzzWeb.ViewModels.Person;

namespace FizzBuzzWeb.ViewModels
{
    public class ListPersonForListVM
    {
        public int Id { get; set; }
        public List<PersonForListVM> People { get; set; } = null!;
        public int Count { get; set; }
    }
}
