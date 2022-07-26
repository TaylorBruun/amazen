using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amazen.Models;
using amazen.Services;
using Microsoft.AspNetCore.Mvc;

namespace amazen.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }


        [HttpGet]
        public ActionResult<List<Product>> GetAll(){
            try
            {
                List<Product> products = _productsService.GetAll();
                return Ok(products);
            }
            catch (System.Exception exception)
            {
                return BadRequest (exception.Message);
            }
        }

        [HttpPost]
        public ActionResult<Product> Create([FromBody] Product productData){
            try
            {
                
                Product product = _productsService.Create(productData);
                return Ok(product);
            }
            catch (System.Exception exception)
            {
                
                return BadRequest(exception.Message);
            }
        }

    }
}