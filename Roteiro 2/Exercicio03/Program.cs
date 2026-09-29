using System;

class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        andarAtual = 0;
    }

    public void Subir()
    {
        if (andarAtual < totalAndares) andarAtual++;
    }

    public void Descer()
    {
        if (andarAtual > 0) andarAtual--;
    }

    public void ExibirAndar()
    {
        Console.WriteLine(andarAtual);
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(10);
        e.Subir();
        e.Subir();
        e.ExibirAndar();
        e.Descer();
        e.ExibirAndar();
        e.Descer();
        e.Descer();
        e.ExibirAndar();
    }
}
