using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Conrollers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);
    }
}