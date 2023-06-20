
public class Continente
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public List<Territorio> Territori { get; set; }

    public Continente(string id, string nome, List<Territorio> territori)
    {
        Id = id;
        Nome = nome;
        Territori = territori;
    }
}
