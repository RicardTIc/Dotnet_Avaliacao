using System;
using System.Collections.Generic;
using System.Linq;

// Classe Advogado
public class Advogado
{
    public string Nome {get; set;}  
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
    public string CNA { get; set; }
}

// Classe Cliente
public class Cliente
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
    public string EstadoCivil { get; set; }
    public string Profissao { get; set; }
}
