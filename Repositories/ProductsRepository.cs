using LojaDiversidades.Entities;

namespace LojaDiversidades.Repositories;
public class ProductsRepository
{
	public List<ProductsList> Lista()
	{
		try
		{
			return new List<ProductsList>();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}
	public Product Pesquisa(int id)
	{
		try
		{
			return new Product();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
		
	}
	public bool Salva(Product produto)
	{
		try
		{
			if(produto.Id != 0)
			{
				return true;
			}
			else
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
	public bool Exclui(int id)
	{
		try
		{
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
}