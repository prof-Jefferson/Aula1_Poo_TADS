using System;

class Program
{
    static void Main(string[] args)
    {
        // Criação de um novo Carro
        Carro meuCarro = new Carro();

        // Configurando o carro
        meuCarro.SetMarca("Toyota");
        meuCarro.SetModelo("Corolla");
        meuCarro.SetAno(2020);

        // Exibindo informações do carro
        Console.WriteLine($"Marca: {meuCarro.GetMarca()}");
        Console.WriteLine($"Modelo: {meuCarro.GetModelo()}");
        Console.WriteLine($"Ano: {meuCarro.GetAno()}");
    }
}
