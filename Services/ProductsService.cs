using LojaDiversidades.Repositories;
using LojaDiversidades.Entities;

namespace LojaDiversidades.Services;
public class ProductsService
{
	public List<ProductsList> ListarProdutos()
	{
		try
		{

			return new ProductsRepository().Lista();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}
	public Product PesquisarProduto(int id)
	{
		try
		{
			return new ProductsRepository().Pesquisa(id);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}
	public bool IncluirProduto(Product produto)
	{
		try
		{
			return new ProductsRepository().Salva(produto);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
	public bool AlterarProduto(Product produto)
	{
		try
		{
			return new ProductsRepository().Salva(produto);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			throw;
		}
	}
	public bool ExcluirProduto(int id)
	{
		try
		{
			return new ProductsRepository().Exclui(id);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
}