public class EscritorioAdvocacia
{
    public List<Advogado> Advogados { get; private set; }
    public List<Cliente> Clientes { get; private set; }

    public EscritorioAdvocacia()
    {
        Advogados = new List<Advogado>();
        Clientes = new List<Cliente>();
    }

    // Método para adicionar Advogado
    public void AdicionarAdvogado(Advogado advogado)
    {
        // Validação de CPF e CNA únicos
        if (Advogados.Any(a => a.CPF == advogado.CPF) || Advogados.Any(a => a.CNA == advogado.CNA))
        {
            throw new ArgumentException("CPF ou CNA já cadastrado para outro advogado.");
        }

        Advogados.Add(advogado);
    }

    // Método para adicionar Cliente
    public void AdicionarCliente(Cliente cliente)
    {
        // Validação de CPF único
        if (Clientes.Any(c => c.CPF == cliente.CPF))
        {
            throw new ArgumentException("CPF já cadastrado para outro cliente.");
        }

        Clientes.Add(cliente);
    }

    // Relatórios utilizando LINQ e expressões lambda

    // Advogados com idade entre dois valores
    public List<Advogado> AdvogadosEntreIdades(int idadeMinima, int idadeMaxima)
    {
        DateTime dataAtual = DateTime.Now;
        return Advogados.Where(a => (dataAtual - a.DataNascimento).TotalDays / 365 >= idadeMinima &&
                                     (dataAtual - a.DataNascimento).TotalDays / 365 <= idadeMaxima).ToList();
    }

    // Clientes com idade entre dois valores
    public List<Cliente> ClientesEntreIdades(int idadeMinima, int idadeMaxima)
    {
        DateTime dataAtual = DateTime.Now;
        return Clientes.Where(c => (dataAtual - c.DataNascimento).TotalDays / 365 >= idadeMinima &&
                                   (dataAtual - c.DataNascimento).TotalDays / 365 <= idadeMaxima).ToList();
    }

    // Clientes com estado civil informado
    public List<Cliente> ClientesPorEstadoCivil(string estadoCivil)
    {
        return Clientes.Where(c => c.EstadoCivil.Equals(estadoCivil, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Clientes em ordem alfabética
    public List<Cliente> ClientesOrdemAlfabetica()
    {
        return Clientes.OrderBy(c => c.Nome).ToList();
    }

    // Clientes cuja profissão contenha texto informado
    public List<Cliente> ClientesPorProfissao(string texto)
    {
        return Clientes.Where(c => c.Profissao.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Advogados e Clientes aniversariantes do mês informado
    public List<object> AniversariantesDoMes(int mes)
    {
        return Advogados.Concat<object>(Clientes)
                        .Where(p =>
                        {
                            if (p is Advogado adv)
                                return adv.DataNascimento.Month == mes;
                            else if (p is Cliente cli)
                                return cli.DataNascimento.Month == mes;
                            return false;
                        })
                        .ToList();
    }
}
