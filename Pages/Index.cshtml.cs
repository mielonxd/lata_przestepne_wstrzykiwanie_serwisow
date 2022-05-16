using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.ViewModels;
using FizzBuzzWeb.ViewModels.Person;
using FizzBuzzWeb.Services;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;

        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        public ListPersonForListVM Records { get; set; } = null!;
        public void OnGet()
        {
            Records = _personService.GetEntriesFromToday();
        }
        public void OnPost()
        {
            
        }
        //  [BindProperty]
        //public Person Person { get; set; } = null!;
    }
}