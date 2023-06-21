public class Esercito
{
    public string id { get; set; }
    public List<Territorio> TerritoriContenuti { get; set; }
    public List<Obiettivo> Obiettivo { get; set; }




    public Esercito(string Id)
    {
        id = Id;
        TerritoriContenuti = new List<Territorio>();
        Obiettivo = new List<Obiettivo>();

    }

    public void InserisciTerritorio(Territorio territorio)
    {
        TerritoriContenuti.Add(territorio);
    }

    public void StampaTerritori()
    {
        Console.WriteLine($"Territori dell'Esercito {id}:");
        foreach (Territorio territorio in TerritoriContenuti)
        {
            Console.WriteLine($" Nome: {territorio.Nome}");
        }
    }


    public void AggiungiObiettivo(List<Obiettivo> obiettivi)
    {
        Random random = new Random();

        int indiceObiettivo = random.Next(obiettivi.Count);

        Obiettivo.Add(obiettivi[indiceObiettivo]);
    }

    //public void AggiungiTruppa(List<Truppa> truppe)
    //{
    //    Random random = new Random();
    //
    //    int truppa1 = random.Next(truppe.Count);
    //    int truppa2 = random.Next(truppe.Count);
    //    int truppa3 = random.Next(truppe.Count);
    //
    //    Truppe.Add(truppe[truppa1]);
    //    Truppe.Add(truppe[truppa2]);
    //    Truppe.Add(truppe[truppa3]);
    //}


}
