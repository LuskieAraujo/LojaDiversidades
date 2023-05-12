using LojaDiversidades.Entities;

namespace LojaDiversidades.Mock;

public class MockProduct
{
	public List<Product> Products()
	{
		return new List<Product>
		{
			new Product
			{
				Id = 1,
				Code = "1234567890",
				Name = "Papel A4",
				Description = "Folha de sulfite de tamanho A4.",
				Price = 1.25f,
				Quantity = 1000,
				IsActive = true
			},
			new Product
			{
				Id = 2,
				Code = "0123456789",
				Name = "Fita Adesiva",
				Description = "Fita auto-colante.",
				Price = 2.5f,
				Quantity = 100,
				IsActive = false
			},
			new Product
			{
				Id = 3,
				Code = "0987654321",
				Name = "Caneta Azul",
				Description = "Caneta esferográfica.",
				Price = 1.5f,
				Quantity = 50,
				IsActive = false
			},
			new Product
			{
				Id = 4,
				Code = "9876543210",
				Name = "Lápis Preto",
				Description = "Lápis grafite Nº2B.",
				Price = 1,
				Quantity = 1500,
				IsActive = true
			}
		};
	}
}