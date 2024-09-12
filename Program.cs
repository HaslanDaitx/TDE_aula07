Estoque baitaca = new Estoque();
Console.WriteLine("Informe o nome do produto para adicionar ao estoque: ");
baitaca.produto= Console.ReadLine();
Console.WriteLine("Informe a quantidade de produtos e estoque:");
int quantidade = Convert.ToInt32(Console.ReadLine());
baitaca.AdicionarEstoque(quantidade);
Console.WriteLine("Informe o valor do produto:");
baitaca.preco = Convert.ToDouble(Console.ReadLine());
baitaca.ExibeInformacoes();
