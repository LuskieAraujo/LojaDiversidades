namespace LojaDiversidades.Entities;
public class Order
{
	public int UserId { get; set; }
	public int Id { get; set; }
	public bool Delivered { get; set; }
	public List<OrderItems>? OrderItems { get; set; }
	public DateTime? CreatedDate { get; set; }
}