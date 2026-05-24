using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using DataAccessLayer.Models;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class OnderdelenModel : PageModel

    {
        public List<Part> Bestellingen => ProductdetailsModel.Bestellingen;

        public void OnGet()
        {

        }



        public void OnPost(string naam)
        {
            ProductdetailsModel.Bestellingen.Add(new Part { Name = naam });
        }


    }
}
