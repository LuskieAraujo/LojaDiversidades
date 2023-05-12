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
	public int IncluiPedido(Order pedido)
	{
		try
		{
			return new Random().Next(1, int.MaxValue);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return 0;
		}
	}
	public List<OrderItems> ListaItensPedido(int idUsuario, int idPedido)
	{
		try
		{
			return new List<OrderItems>();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new List<OrderItems>();
		}
	}
	public bool IncluiItemPedido(int idUsuario, OrderItems item)
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
	public bool ExcluiItemPedido(int idUsuario, int idPedido, int idItem)
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
	public bool ExcluiListaItensPedido(int idUsuario, int idPedido)
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
	public bool AlteraItemPedido(int idUsuario, OrderItems item)
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