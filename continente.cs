
public class Continente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Territorio> Territori { get; set; }

    public Continente(int id, string nome, List<Territorio> territori)
    {
        Id = id;
        Nome = nome;
        Territori = territori;
    }
}
