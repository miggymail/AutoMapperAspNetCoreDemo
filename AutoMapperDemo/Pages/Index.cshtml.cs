using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AutoMapperDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMapper _mapper;

        [BindProperty()]
        public List<CustomerDto> Customers { get; set; }

        [BindProperty()]
        public List<ProductDto> Products { get; set; }

        [BindProperty()]
        public List<VendorDto> Vendors { get; set; }

        public IndexModel(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void OnGet()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() {
                Id = 1,
                Company = "The Good Company",
                FirstName = "Steve",
                LastName = "Rogers"},
               new Customer() {
                Id = 3,
                Company = "The Bright Company",
                FirstName = "Tony",
                LastName = "Stark"},
                new Customer() {
                Id = 5,
                Company = "The Big Company",
                FirstName = "Bruce",
                LastName = "Banner"},
            };

            List<Product> products = new List<Product>(){
            new Product()
            {
                Id = 1000,
                ItemName = "Colorful Boomerang",
                ItemDescription = "Boomerang",
                UnitPrice = 15M,
                UOM = "Each"
            },
            new Product()
            {
                Id = 1003,
                ItemName = "Game of Thrones Board Game",
                ItemDescription = "Board Games",
                UnitPrice = 25M,
                UOM = "Each"
            },
            new Product()
            {
                Id = 1005,
                ItemName = "Iron Man Figure",
                ItemDescription = "Action Figure",
                UnitPrice = 45M,
                UOM = "Each"
            }
            };

            List<Vendor> vendors = new List<Vendor>()
            {
            new Vendor()
            {
                Id = 2007,
                Name = "Marvel",
                Description = "Marvel Supplier"
            },
            new Vendor()
            {
                Id = 2008,
                Name = "Disney",
                Description = "Disney Supplier"
            },
            new Vendor()
            {
                Id = 2009,
                Name = "The Toy Company",
                Description = "Toy Supplier"
            }
            };

            Customers = _mapper.Map<List<Customer>, List<CustomerDto>>(customers);

            Products = _mapper.Map<List<Product>, List<ProductDto>>(products);

            Vendors = _mapper.Map<List<Vendor>, List<VendorDto>>(vendors);
        }
    }
}
