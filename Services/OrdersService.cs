using LojaDiversidades.Repositories;
using LojaDiversidades.Entities;

namespace LojaDiversidades.Services;
public class OrdersService
{
	public List<Order> ListarPedidos(int idUsuario)
	{
		try
		{
			return new OrdersRepository().ListaPedidos(idUsuario);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new List<Order>();
		}
	}
	public Order PesquisarPedido(int idUsuario, int idPedido)
	{
		var repositorio = new OrdersRepository();

		try
		{
			var ped = repositorio.PesquisaPedido(idUsuario, idPedido);
			ped.OrderItems = repositorio.ListaItensPedido(idUsuario, idPedido);
			return ped;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new Order();
		}
	}
	public bool ExcluirPedido(int idUsuario, int idPedido)
	{
		var repositorio = new OrdersRepository();
		try
		{
			bool itensExcluidos = repositorio.ExcluiListaItensPedido(idUsuario, idPedido);
			return itensExcluidos ? repositorio.ExcluiPedido(idUsuario, idPedido) : false;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
	public int IncluirPedido(Order pedido)
	{
		try
		{
			return new OrdersRepository().IncluiPedido(pedido);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return 0;
		}
	}
	public bool IncluirItemPedido(int idUsuario, OrderItems item)
	{
		try
		{
			return new OrdersRepository().IncluiItemPedido(idUsuario, item);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
	public bool ExcluirItemPedido(int idUsuario, int idPedido, int idItem)
	{
		try
		{
			return new OrdersRepository().ExcluiItemPedido(idUsuario, idPedido, idItem);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
	public bool AlterarItemPedido(int idUsuario, OrderItems item)
	{
		try
		{
			return new OrdersRepository().AlteraItemPedido(idUsuario, item);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
}