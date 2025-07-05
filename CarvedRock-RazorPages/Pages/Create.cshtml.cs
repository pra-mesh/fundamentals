using DataLibrary.model;
using DataLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarvedRock_RazorPages.Pages;

public class CreateModel : PageModel
{
  private readonly IProductRepository _productRepository;

  public CreateModel(IProductRepository productRepository)
  {
    _productRepository = productRepository;
  }
  [BindProperty]
  public Product NewProduct { get; set; } = new Product();
  public async Task<IActionResult> OnPost()
  {
    if (!ModelState.IsValid)
    {
      return Page();
    }
    await _productRepository.Add(NewProduct);
    return RedirectToPage("Index");
  }
}