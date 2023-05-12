using LojaDiversidades.Repositories;
using LojaDiversidades.Entities;

namespace LojaDiversidades.Services;
public class ProductsService
{
	private ProductsRepository repositorio = new ProductsRepository();
	public List<Product> Listar()
	{
		try
		{
			return repositorio.Lista();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}
	public Product PesquisarProduto(int id)
	{
		try
		{
			return repositorio.Pesquisa(id);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
    }
    public Product PesquisarCodigo(string codigo)
    {
        try
        {
            return repositorio.PesquisaCodigo(codigo);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    public bool Salvar(int id,Product produto)
	{
		try
		{
			return produto.Id != 0 ? repositorio.Altera(id, produto) : repositorio.Inclui(produto);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			throw;
		}
	}
	public bool Excluir(int id)
	{
		try
		{
			return repositorio.Exclui(id);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
}