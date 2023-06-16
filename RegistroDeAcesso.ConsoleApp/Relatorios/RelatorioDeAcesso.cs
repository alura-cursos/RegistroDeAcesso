namespace RegistroDeAcesso.Relatorios;

internal class RelatorioDeAcesso
{
    private List<AcessoAoPredio> acessos = new();
    public void RegistrarEntrada(??? entrada)
    {
        acessos.Add(new AcessoAoPredio(DateTime.Now, ???));
    }

    public void ExibirRegistroDoMes()
    {
        Console.WriteLine("Acessos registrados no mês:");
        foreach (var acesso in acessos)
        {
            Console.WriteLine($"- {acesso.Resumo} em {acesso.Entrada}");
        }
    }
}
