using LojaDiversidades.Entities;
using LojaDiversidades.Mock;

namespace LojaDiversidades.Repositories;
public class ProductsRepository
{
    private List<Product> produtosMock = new MockProduct().Products();

    public List<Product> Lista()
    {
        try
        {
            return produtosMock;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    public Product Pesquisa(int id)
    {
        try
        {
            return produtosMock.Where(x => x.Id == id).First();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    public Product PesquisaCodigo(string codigo)
    {
        try
        {
            return produtosMock.Where(x => x.Code == codigo).First();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }

    }
    public bool Inclui(Product produto)
    {
        try
        {
            int count = produtosMock.Count;
            produtosMock.Add(produto);
            return count < produtosMock.Count;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    public bool Altera(int id, Product produto)
    {
        try
        {
            Product product = produtosMock.Where(x => x.Id == id).First();

            if (product == null) return false;

            product = produto;
            produtosMock.Remove(produtosMock.Where(x => x.Id == produto.Id).First());
            produtosMock.Add(product);

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    public bool Exclui(int id)
    {
        try
        {
            int count = produtosMock.Count;
            produtosMock.Remove(produtosMock.Where(x => x.Id == id).First());

            return count > produtosMock.Count;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}