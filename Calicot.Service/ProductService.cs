using Calicot.Data.Mock;
using Calicot.Type;
using Calicot.Type.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Service
{
    public class ProductService : IProductService
    {
        private List<ProductModel> listOfProducts;

        public ProductService()
        {
            
            listOfProducts = MockProducts.mocklistProducts;
        }

        public List<ProductModel> GetAllProducts()
        {
            return listOfProducts;
        }

        public ProductModel GetProduct(int productId)
        {
            var product = listOfProducts.Find(x => x.ProductId == productId);
            return product;
        }

        public ProductModel AddProduct(ProductModel product)
        {
            product.ProductId = listOfProducts.Count + 1;
            listOfProducts.Add(product);
            return product;
        }

        public ProductModel UpdateProduct(ProductModel product)
        {
            var index = listOfProducts.FindIndex(x => x.ProductId == product.ProductId);
            listOfProducts[index] = product;
            return product;
        }

        public bool DeleteProduct(int productId)
        {
            var index = listOfProducts.FindIndex(x => x.ProductId == productId);
            listOfProducts.RemoveAt(index);
            return true;
        }
    }
}
