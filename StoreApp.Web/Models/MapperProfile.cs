using AutoMapper;
using StoreApp.Data.Conrete;

namespace StoreApp.Web.Models;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Product, ProductViewModel>();
    }
}