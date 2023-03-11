namespace LojaDiversidades.Entities;
public class OrderItems
{
	public int OrderId { get; set; }
	public int Id { get; set; }
	public string Name { get; set; }
	public int Quantity { get; set; }
	public int ProductId { get; set; }
	public float Price { get; set; }
}