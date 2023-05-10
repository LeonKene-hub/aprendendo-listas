using aprendendo_listas;

List<Produto> produtos = new List<Produto>();

//inserir objtos na lista

//atraves de uma instancia basica de objeto
Produto camiseta = new Produto(1234, "lacoste", 19.99f);
produtos.Add(camiseta);

//atraves de uma instancia direta (com construtor)
produtos.Add(
    new Produto(1235, "nike", 21.99f)
);

//-------------READ-------------//
Console.WriteLine($"Produtos antes da alteracao");
foreach (var item in produtos)
{
    Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:c}");
}

//-------------UPDATE-------------//

//acessar um objeto da lista para poder manipula-lo
Produto produtoEncontrado = produtos.Find(x => x.Codigo == 1234);

//encontrar o indice do produto encontrado
int index = produtos.IndexOf(produtoEncontrado);

//exibir o indice no console
Console.WriteLine($"O indice do produto encontrado e {index}");

//fazer alteracoes
produtoEncontrado.Preco = 599f;

//remover o item antigo da lista
produtos.RemoveAt(index);

//devolver o item atualizado no lugar
produtos.Insert(index, produtoEncontrado);

Console.WriteLine($"Produtos depois da alteracao");
foreach (var item in produtos)
{
    Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:c}");
}

//-------------DELETE-------------//
produtos.RemoveAt(1);