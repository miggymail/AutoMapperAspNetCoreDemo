using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDemo.Models;

namespace AutoMapperDemo.Data
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Customer, CustomerDto>();

            CreateMap<Product, ProductDto>();

            CreateMap<Vendor, VendorDto>();
        }
    }
}
