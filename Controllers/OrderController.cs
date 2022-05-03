using Microsoft.AspNetCore.Mvc;

namespace Swift_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OrderController : ControllerBase
    {
        public class CustomerController : ControllerBase
        {
            private readonly DataContext _dataContext;
            //constructor
            public CustomerController(DataContext dataContext)
            {
                _dataContext = dataContext;
            }


            //Retrieve order info
            [HttpGet]
            public async Task<ActionResult<List<Order>>> Get()
            {
                return Ok(await _dataContext.Orders.ToListAsync());
            }


            [HttpGet("{OrderId}")]
            public async Task<ActionResult<List<Order>>> Get(int OrderId)
            {
                var order = await _dataContext.Customers.FindAsync(OrderId);
                if (order == null)
                    return BadRequest("Order not found.");
                return Ok(order);
            }

            //Add new order
            [HttpPost]
            public async Task<ActionResult<List<Order>>> AddOrder(Order order)
            {
                _dataContext.Orders.Add(order);
                await _dataContext.SaveChangesAsync();

                return Ok(await _dataContext.Orders.ToListAsync());
            }

        }
    }
}
