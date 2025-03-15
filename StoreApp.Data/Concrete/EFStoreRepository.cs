using StoreApp.Data.Abstract;

namespace StoreApp.Data.Conrete;

public class EFStoreRepository : IStoreRepository
{
    private readonly StoreDbContext _context;

    public EFStoreRepository(StoreDbContext context)
    {
        _context = context;
    }

    public IQueryable<Product> Products => _context.Products;

    public void CreateProduct(Product entity)
    {
        
    }
}