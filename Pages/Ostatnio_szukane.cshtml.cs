using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.ViewModels;

namespace FizzBuzzWeb.Pages
{
    public class Ostatnio_szukaneModel : PageModel
    {
        private readonly ILogger<Ostatnio_szukaneModel> _logger;
        private readonly IPersonService _personService;
        public ListPersonForListVM Records { get; set; }
        public Ostatnio_szukaneModel(ILogger<Ostatnio_szukaneModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        public void OnGet()
        {
            Records = _personService.GetAllEntries();
        }
    }
}
