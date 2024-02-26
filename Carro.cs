using System;

public class Carro
{
    private string marca;
    private string modelo;
    private int ano;

    // Métodos públicos
    public string GetMarca()
    {
        return marca;
    }

    public void SetMarca(string marca)
    {
        this.marca = marca;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public int GetAno()
    {
        return ano;
    }

    public void SetAno(int ano)
    {
        // Obtém o ano atual
        int anoAtual = DateTime.Now.Year;

        // Verifica se o ano está dentro do intervalo aceitável
        if (ano >= 1980 && ano <= anoAtual)
        {
            this.ano = ano;
            Console.WriteLine($"Ano do carro definido para {ano}.");
        }
        else
        {
            Console.WriteLine($"Erro: Ano {ano} inválido. Deve estar entre 1980 e {anoAtual}.");
        }
    }
}
