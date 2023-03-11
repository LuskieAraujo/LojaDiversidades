using LojaDiversidades.Repositories;
using LojaDiversidades.Entities;

namespace LojaDiversidades.Services;
public class OrdersService
{
	public List<Order> ListarPedidos(int idUsuario)
	{
		try
		{
			return new OrdersRepository().Lista(idUsuario);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new List<Order>();
		}
	}
	public Order PesquisarPedido(int idUsuario, int idPedido)
	{
		try
		{
			return new OrdersRepository().Pesquisa(idUsuario, idPedido);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new Order();
		}
	}
}