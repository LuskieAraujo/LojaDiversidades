using Microsoft.AspNetCore.Mvc;
using LojaDiversidades.Entities;
using LojaDiversidades.Services;

namespace LojaDiversidades.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		[HttpGet("{id}")]
		public ActionResult<IEnumerable<Order>> GetOrders(int idUsuario)
		{
			try
			{
				return Ok(new OrdersService().ListarPedidos(idUsuario));
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

		[HttpGet("{id}/{idP}")]
		public ActionResult<Order> GetOrder(int idUsuario, int idPedido)
		{
			try
			{
				return Ok(new Order());
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
