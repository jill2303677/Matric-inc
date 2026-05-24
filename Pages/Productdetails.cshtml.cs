using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class ProductdetailsModel : PageModel
    {
        public static List<Part> Bestellingen { get; set; } = new List<Part>();

        public void OnGet()
        {

        }

        public void OnPost(string naam)
        {
            Bestellingen.Add(new Part { Name = naam });



        }

    }
}
