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
        this.ano = ano;
    }
}
