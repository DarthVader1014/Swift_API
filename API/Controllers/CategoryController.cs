using Microsoft.AspNetCore.Mvc;

namespace Swift_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _dataContext;
        //constructor
        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        //Retrieve category info
        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return Ok(await _dataContext.Categories.ToListAsync());
        }


        [HttpGet("{CategoryId}")]
        public async Task<ActionResult<List<Category>>> Get(int CategoryId)
        {
            var category = await _dataContext.Categories.FindAsync(CategoryId);
            if (category == null)
                return BadRequest("Category not found.");
            return Ok(category);
        }
    }
}
