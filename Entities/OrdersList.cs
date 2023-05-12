namespace LojaDiversidades.Entities;
public class OrdersList
{
	public int UserId { get; set; }
	public int Id { get; set; }
	public int TotalItems { get; set; }
	public float TotalAmount { get; set; }
	public DateTime CreatedDate { get; set; }
}