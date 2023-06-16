namespace RegistroDeAcesso.Modelos;

internal class Entrega : IResumoAcesso
{
    public Entrega(string representante)
    {
        Representante = representante;
    }

    public string Representante { get; }

    public string Resumo => $"Entrega feita pelo representante {Representante}";
}