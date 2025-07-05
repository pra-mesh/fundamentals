using DataLibrary.model;
using DataLibrary.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CarvedRock_RazorPages.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IProductRepository _productRepository;

    public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }
    public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
    public async Task OnGet()
    {
        Products = await _productRepository.GetAll();
    }
}
