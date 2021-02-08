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
            listOfProducts = new List<ProductModel>();
        }

        public List<ProductModel> GetAllProducts()
        {
            return listOfProducts;
        }

        public ProductModel GetProduct(int productId)
        {
            var product = listOfProducts.Find(x => x.productId == productId);
            return product;
        }

        public ProductModel AddProduct(ProductModel product)
        {
            product.productId = listOfProducts.Count + 1;
            listOfProducts.Add(product);
            return product;
        }

        public ProductModel UpdateProduct(ProductModel product)
        {
            var index = listOfProducts.FindIndex(x => x.productId == product.productId);
            listOfProducts[index] = product;
            return product;
        }

        public bool DeleteProduct(int productId)
        {
            var index = listOfProducts.FindIndex(x => x.productId == productId);
            listOfProducts.RemoveAt(index);
            return true;
        }
    }
}
