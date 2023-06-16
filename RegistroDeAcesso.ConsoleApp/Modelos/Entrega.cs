namespace RegistroDeAcesso.Modelos;

internal class Entrega
{
    public Entrega(string representante)
    {
        Representante = representante;
    }

    public string Representante { get; }
}