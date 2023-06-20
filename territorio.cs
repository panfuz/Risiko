public class Territorio
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string IdContinente { get; set; }
    public string Simbolo { get; set; }
    public string Confine { get; set; }

    public Territorio(string id, string nome, string idContinente, string simbolo, string confine)
    {
        Id = id;
        Nome = nome;
        IdContinente = idContinente;
        Simbolo = simbolo;
        Confine = confine;
    }
}