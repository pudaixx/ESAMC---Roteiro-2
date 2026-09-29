using System;

class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;
        this.preco = preco >= 0 ? preco : 0;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine(nome + " - R$" + preco);
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco >= 0) preco = novoPreco;
        else Console.WriteLine("Preço inválido");
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.AlterarPreco(-200);
        p.AlterarPreco(1200);
        p.ExibirDetalhes();
    }
}
