using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class ProductenModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public List<Product> Products { get; set; }

        public bool Besteld { get; set; }

        public ProductenModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void OnGet(bool besteld)
        {
            Besteld = besteld;
            Products = _productRepository.GetAllProducts().ToList();
        }


        public void OnPost()
        {
            Besteld = true;
        }
    }
}