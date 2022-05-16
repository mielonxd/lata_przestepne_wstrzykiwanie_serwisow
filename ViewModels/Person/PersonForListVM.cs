namespace FizzBuzzWeb.ViewModels.Person
{
    public class PersonForListVM
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Year { get; set; }
        public DateTime? localDate { get; set; }

        public string description = null!;
        public string check()
        {
            if (DateTime.IsLeapYear(Year))
            {
                description = " - rok przestępny";
                return FullName + " urodził/a się w " + Year + " roku. To był rok przestępny.";
            }
            else
            {
                description = " - rok zwykły";
                return FullName + " urodził/a się w " + Year + " roku. To nie był rok przestępny.";
            }
        }
    }
}
