using Microsoft.AspNetCore.Mvc;

namespace Swift_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dataContext;
        //constructor
        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        //Retrieve product info
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(await _dataContext.Products.ToListAsync());
        }

        [HttpGet("{ProductId}")]
        public async Task<ActionResult<List<Product>>> Get(int ProductId)
        {
            var product = await _dataContext.Products.FindAsync(ProductId);
            if (product == null)
                return BadRequest("Product not found.");
            return Ok(product);
        }

        //Add new product
        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {
            _dataContext.Products.Add(product);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Products.ToListAsync());
        }

        //Update product records
        [HttpPut]
        public async Task<ActionResult<List<Product>>> UpdateProduct(Product request)
        {
            var dbproduct = await _dataContext.Products.FindAsync(request.ProductId);
            if (dbproduct == null)
                return BadRequest("Product not found.");

            dbproduct.ProductId = request.ProductId;
            dbproduct.ProductName = request.ProductName;
            dbproduct.ProductPrice = request.ProductPrice;
            dbproduct.CategoryId = request.CategoryId;
            dbproduct.ProductDesc = request.ProductDesc;


            await _dataContext.SaveChangesAsync();


            return Ok(await _dataContext.Products.ToListAsync());

        }

        //Delete product records
        [HttpDelete("{ProductId}")]

        public async Task<ActionResult<List<Product>>> Delete(int ProductId)
        {
            var dbproduct = await _dataContext.Products.FindAsync(ProductId);
            if (dbproduct == null)
                return BadRequest("Product not found.");

            _dataContext.Products.Remove(dbproduct);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Products.ToListAsync());
        }

    }
}
