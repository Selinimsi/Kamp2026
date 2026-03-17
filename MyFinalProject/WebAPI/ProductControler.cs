using Busniess.Abstract;
using Busniess.Concrete;
using DataAccess.Concrete.EntitiyFrameWork;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Attribute yani bu bir imza .Net e bu bir controller demiş oluyoruz
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {   //dependrncy chain--> bağımlılık zinciri
            IProductService productService = new ProductManager(new EfProductDal());
            var result = productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
           
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {   //dependrncy chain--> bağımlılık zinciri
            
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);

        }

        [HttpPost("Add")]
        public IActionResult Add(Product product) {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
    }
}