using Microsoft.AspNetCore.Mvc;

namespace Swift_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class P_ImageController : ControllerBase
    {
        private readonly DataContext _dataContext;
        //constructor
        public P_ImageController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //Retrieve image info
        [HttpGet]
        public async Task<ActionResult<List<P_image>>> Get()
        {
            return Ok(await _dataContext.P_images.ToListAsync());
        }


        [HttpGet("{ImageId}")]
        public async Task<ActionResult<List<P_image>>> Get(int ImageId)
        {
            var image = await _dataContext.P_images.FindAsync(ImageId);
            if (image == null)
                return BadRequest("Customer not found.");
            return Ok(image);
        }

        //Add new image
        [HttpPost]
        public async Task<ActionResult<List<P_image>>> AddCustomer(P_image p_image)
        {
            _dataContext.P_images.Add(p_image);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.P_images.ToListAsync());
        }

    }
}
