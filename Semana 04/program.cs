using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
}

public class Advogado : Pessoa
{
    public string CPF { get; set; }
    public string CNA { get; set; }

    public Advogado(string nome, DateTime dataNascimento, string cpf, string cna)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
        CNA = cna;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, CPF: {CPF}, CNA: {CNA}";
    }
}

public class Cliente : Pessoa
{
    public string EstadoCivil { get; set; }
    public string Profissao { get; set; }

    public Cliente(string nome, DateTime dataNascimento, string estadoCivil, string profissao)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        EstadoCivil = estadoCivil;
        Profissao = profissao;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Estado Civil: {EstadoCivil}, Profissão: {Profissao}";
    }
}

public class Program
{
    public static List<Advogado> Advogados = new List<Advogado>();
    public static List<Cliente> Clientes = new List<Cliente>();

    public static void AdicionarAdvogado(Advogado advogado)
    {
        if (!Advogados.Any(a => a.CPF == advogado.CPF))
        {
            Advogados.Add(advogado);
        }
        else
        {
            throw new ArgumentException("CPF já existe.");
        }
    }

    public static void AdicionarCliente(Cliente cliente)
    {
        if (!Clientes.Any(c => c.Nome == cliente.Nome))
        {
            Clientes.Add(cliente);
        }
        else
        {
            throw new ArgumentException("Cliente já existe.");
        }
    }

    public static void RelatorioAdvogadosIdade(int idadeMinima, int idadeMaxima)
    {
        var advogados = Advogados.Where(a => (DateTime.Now.Year - a.DataNascimento.Year) >= idadeMinima && (DateTime.Now.Year - a.DataNascimento.Year) <= idadeMaxima);

        foreach (var advogado in advogados)
        {
            Console.WriteLine(advogado);
        }
    }

    public static void RelatorioClientesIdade(int idadeMinima, int idadeMaxima)
    {
        var clientes = Clientes.Where(c => (DateTime.Now.Year - c.DataNascimento.Year) >= idadeMinima && (DateTime.Now.Year - c.DataNascimento.Year) <= idadeMaxima);

        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }

    public static void RelatorioClientesEstadoCivil(string estadoCivil)
    {
        var clientes = Clientes.Where(c => c.EstadoCivil == estadoCivil);

        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }

    public static void RelatorioClientesOrdemAlfabetica()
    {
        var clientes = Clientes.OrderBy(c => c.Nome);

        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }

    public static void RelatorioClientesProfissao(string profissao)
    {
        var clientes = Clientes.Where(c => c.Profissao.Contains(profissao));

        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }

    static void Main()
    {
        // Exemplo de utilização
        AdicionarAdvogado(new Advogado("Advogado1", new DateTime(1980, 1, 1), "123456789", "CNA123"));
        AdicionarAdvogado(new Advogado("Advogado2", new DateTime(1990, 1, 1), "987654321", "CNA456"));

        AdicionarCliente(new Cliente("Cliente1", new DateTime(1985, 1, 1), "Casado", "Engenheiro"));
        AdicionarCliente(new Cliente("Cliente2", new DateTime(2000, 1, 1), "Solteiro", "Médico"));

        RelatorioAdvogadosIdade(30, 40);
        RelatorioClientesIdade(20, 40);
    }
}