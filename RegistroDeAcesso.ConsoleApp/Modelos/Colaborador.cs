namespace RegistroDeAcesso.Modelos;

internal class Colaborador : IResumoAcesso
{
    public Colaborador(int idAcesso)
    {
        IdAcesso = idAcesso;
    }

    public int IdAcesso { get; }

    public string Resumo => $"Colaborador id: {IdAcesso}";
}