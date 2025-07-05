using DataLibrary.model;

namespace DataLibrary.Repository;

public interface IProductRepository
{
  Task<Product> Add(Product product);
  Task<IEnumerable<Product>> GetAll();
  Task<Product?> GetById(int id);
}
