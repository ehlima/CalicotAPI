using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Type.Interfaces
{
    public interface IProductService
    {
        List<ProductModel> GetAllProducts();
        ProductModel GetProduct(int productId);
        ProductModel AddProduct(ProductModel product);
        ProductModel UpdateProduct(ProductModel product);
        bool DeleteProduct(int productId);
    }
}
