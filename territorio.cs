public class Territorio
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string IdContinente { get; set; }
    public string Simbolo { get; set; }
    public List<Territorio> TerritoriConfinanti { get; set; }

    public Territorio(string id, string nome, string idContinente, string simbolo)
    {
        Id = id;
        Nome = nome;
        IdContinente = idContinente;
        Simbolo = simbolo;
        TerritoriConfinanti = new List<Territorio>();
    }

    public void AggiungiTerritoriCasuali(List<Territorio> territori)
    {
        Random random = new Random();

        int indiceTerritorio1 = random.Next(territori.Count);
        int indiceTerritorio2 = random.Next(territori.Count);

        TerritoriConfinanti.Add(territori[indiceTerritorio1]);
        TerritoriConfinanti.Add(territori[indiceTerritorio2]);
    }
}

