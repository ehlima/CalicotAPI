using Calicot.Type;
using Calicot.Type.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CALICOT.NETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("all")]
        public List<ProductModel> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet]
        public ProductModel GetProduct([FromQuery] int productId)
        {
            return _productService.GetProduct(productId);
        }

        [HttpPost("Product")]
        public ProductModel AddProduct([FromBody]ProductModel product)
        {
            return _productService.AddProduct(product);
        }

        [HttpPut("Product")]
        public ProductModel UpdateProduct([FromBody] ProductModel product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("Product")]
        public bool DeleteProduct([FromQuery] int productId)
        {
            return _productService.DeleteProduct(productId);
        }
    }
}
