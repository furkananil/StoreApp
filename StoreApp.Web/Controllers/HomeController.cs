using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    public int pageSize = 3;
    private IStoreRepository _storeRepository;
    private IMapper _mapper;
    public HomeController(IStoreRepository storeRepository, IMapper mapper)
    {
        _storeRepository = storeRepository;
        _mapper = mapper;
    }

    //localhost/?page=1
    public IActionResult Index(string category, int page = 1)
    {
        return View(new ProductListViewModel {
            Products = _storeRepository.GetProductsByCategory(category, page, pageSize)
                                    .Select(product => _mapper.Map<ProductViewModel>(product)),
            PageInfo = new PageInfo { 
                ItemsPerPage = pageSize,
                CurrentPage = page,
                TotalItems = _storeRepository.GetProductCount(category)
            }
        });
    } 
}