using Microsoft.AspNetCore.Mvc;
using LojaDiversidades.Services;
using LojaDiversidades.Entities;

namespace LojaDiversidades.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<ProductsList>> Get()
		{
			try
			{
				return Ok(new ProductsService().ListarProdutos());
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

		[HttpGet("{id}")]
		public ActionResult<Product> Get(int id)
		{
			try
			{
				return Ok(new ProductsService().PesquisarProduto(id));
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

		[HttpPost]
		public ActionResult<bool> Post([FromBody] Product produto)
		{
			try
			{
				return Ok(new ProductsService().IncluirProduto(produto));
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

		[HttpPut("{id}")]
		public ActionResult<bool> Put([FromBody] Product produto)
		{
			try
			{
				return Ok(new ProductsService().AlterarProduto(produto));
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

		[HttpDelete("{id}")]
		public ActionResult<bool> Delete(int id)
		{
			try
			{
				return Ok(new ProductsService().ExcluirProduto(id));
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}
	}
}
