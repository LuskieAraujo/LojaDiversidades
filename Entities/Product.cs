﻿namespace LojaDiversidades.Entities;
public class Product
{
	public int Id { get; set; }
	public string Code { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public float? Price { get; set; }
	public int Quantity { get; set; }
	public bool IsActive { get; set; }
}