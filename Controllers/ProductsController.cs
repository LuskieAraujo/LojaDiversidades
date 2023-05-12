using Microsoft.AspNetCore.Mvc;
using LojaDiversidades.Services;
using LojaDiversidades.Entities;

namespace LojaDiversidades.Controllers
{
	[Route("api/Produtos")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private ProductsService servico = new ProductsService();

		[HttpGet]
		public ActionResult<IEnumerable<Product>> Get()
		{
			try
			{
				return Ok(servico.Listar());
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpGet("{id}")]
		public ActionResult<Product> Get(int id)
		{
			try
			{
				return Ok(servico.PesquisarProduto(id));
			}
			catch (Exception)
			{
				return BadRequest();
			}
		}

        [HttpGet("Codigo={codigo}")]
        public ActionResult<Product> Get(string codigo)
        {
            try
            {
                return Ok(servico.PesquisarCodigo(codigo));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
		public ActionResult<bool> Post(Product produto)
		{
			try
			{
				return Ok(servico.Salvar(0, produto));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpPut("{id}")]
		public ActionResult<bool> Put(int id, Product produto)
		{
			try
			{
				return Ok(servico.Salvar(id, produto));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpDelete("{id}")]
		public ActionResult<bool> Delete(int id)
		{
			try
			{
				return Ok(servico.Excluir(id));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}
	}
}
