using api_ecommerce;
using api_ecommerce.Models;

public sealed class ProductService: IProductService {
     ProductContext productContext;

    public ProductService(ProductContext dbContext) {
        productContext = dbContext;
    }

    public IEnumerable<tb_productos> Get() {
        return productContext.Customers;
    }
}



public interface IProductService {
    IEnumerable<tb_productos> Get();
}