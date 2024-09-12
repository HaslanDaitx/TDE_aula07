class Estoque
{
    public string produto;
    public int quantidade;
    public double preco;

    public void AdicionarEstoque(int valor)
    {
        quantidade += valor;
    }
    public void RemoverEstoque(int valor)
    {   
        this.quantidade -= quantidade;
    }
    public double RetornaValorTotalDoEstoque()
    {
        return quantidade * preco;
    }
    public void ExibeInformacoes()
    {
        Console.WriteLine($"Nome do produto: {produto}");
        Console.WriteLine($"Quantidade de produtos: {quantidade}");
        Console.WriteLine($"Valor do produto: {preco}");
        Console.WriteLine($"Valor total do Estoque: {RetornaValorTotalDoEstoque}");
        
    }

}
