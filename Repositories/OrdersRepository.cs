using LojaDiversidades.Entities;

namespace LojaDiversidades.Repositories;
public class OrdersRepository
{
	public List<Order> ListaPedidos(int idUsuario)
	{
		try
		{
			return new List<Order>();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new List<Order>();
		}
	}
	public Order PesquisaPedido(int idUsuario, int idPedido)
	{
		try
		{
			return new Order();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new Order();
		}
	}
	public bool ExcluiPedido(int idUsuario, int idPedido)
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
	public bool IncluiPedido(Order pedido)
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
	public bool IncluiItemPedido(int idPedido, OrderItems item)
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
	public bool ExcluiItemPedido(int idPedido, int idItem)
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
	public bool MudarQuantidadeItens(int idPedido, int idItem, int quantidade)
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