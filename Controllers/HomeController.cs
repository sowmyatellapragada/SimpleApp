using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static SimpleApp.Models.Product;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    return View(Product.GetProducts());
        //}
        public IDataSource dataSource = new ProductDataSource();
        public ViewResult Index()
        {
            return View(dataSource.Products);
        }
    }
}
