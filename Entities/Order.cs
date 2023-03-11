namespace LojaDiversidades.Entities;
public class Order
{
	public int UserId { get; set; }
	public int Id { get; set; }
	public int DeliveryType { get; set; }
	public List<OrderItems>? OrderItems { get; set; }
}