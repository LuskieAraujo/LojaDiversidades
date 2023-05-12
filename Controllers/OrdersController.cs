using Microsoft.AspNetCore.Mvc;
using LojaDiversidades.Entities;
using LojaDiversidades.Services;

namespace LojaDiversidades.Controllers
{
	[Route("api/Pedidos")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		[HttpGet("{id}")]
		public ActionResult<IEnumerable<Order>> Get(int idUsuario)
		{
			try
			{
				return Ok(new OrdersService().ListarPedidos(idUsuario));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpGet("u/{idU}/p/{idP}")]
		public ActionResult<Order> Get(int idUsuario, int idPedido)
		{
			try
			{
				return Ok(new OrdersService().PesquisarPedido(idUsuario, idPedido));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpPost]
		public ActionResult<int> Post([FromBody] Order pedido)
		{
			try
			{
				return Ok(new OrdersService().IncluirPedido(pedido));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpPost("u/{idU}")]
		public ActionResult<bool> Post(int idUsuario, [FromBody] OrderItems item)
		{
			try
			{
				return new OrdersService().IncluirItemPedido(idUsuario, item);
			}
			catch (Exception)
			{
				return StatusCode(500);
				throw;
			}
		}

		[HttpPut()]
		public ActionResult<bool> Put(int idUsuario, OrderItems item)
		{
			try
			{
				return Ok(new OrdersService().AlterarItemPedido(idUsuario, item));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpDelete("u/{idU}/p/{idP}")]
		public ActionResult<bool> Delete(int idUsuario, int idPedido)
		{
			try
			{
				return Ok(new OrdersService().ExcluirPedido(idUsuario, idPedido));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpDelete("u/{idU}/p/{idP}/i/{idI}")]
		public ActionResult<bool> Delete(int idUsuario, int idPedido, int idItem)
		{
			try
			{
				return Ok(new OrdersService().ExcluirItemPedido(idUsuario, idPedido, idItem));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}
	}
}
