using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class OrderModel : PageModel
    {
        public List<Part> Orders { get; set; } = new();
        public void OnGet()
        {
            Orders = ProductdetailsModel.Bestellingen;
        }









    }
}

