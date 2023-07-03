public class Esercito
{
    public string id { get; set; }
    public List<Territorio> TerritoriContenuti { get; set; }
    public List<Obiettivo> Obiettivo { get; set; }
    public List<Truppa> Truppe { get; set; }




    public Esercito(string Id)
    {
        id = Id;
        TerritoriContenuti = new List<Territorio>();
        Obiettivo = new List<Obiettivo>();
        Truppe = new List<Truppa>();

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

    public void AggiungiTruppeIniziali()
    {
        int territoriCount = TerritoriContenuti.Count;
        int truppeCount = Truppe.Count;

        int territoriIndex = 0;
        int truppeIndex = 0;

        while (truppeCount >= 0)
        {
            Territorio territorio = TerritoriContenuti[territoriIndex];
            Console.WriteLine("Quante truppe desideri aggiungere al territorio " + territorio.Nome + "?");
            int truppeDaAggiungere = Convert.ToInt32(Console.ReadLine());

            if (truppeDaAggiungere > truppeCount)
            {
                Console.WriteLine("Hai esaurito le truppe e di conseguenza alcuni territori non hanno più truppe. riparti da capo.");
                ResetTerritori();
                return;
            }

            for (int i = 0; i < truppeDaAggiungere; i++)
            {
                Truppa truppa = Truppe[truppeIndex];
                truppa.id_esercito = this.id;
                territorio.Truppe.Add(truppa);

                truppeIndex++;
                truppeCount--;

                if (truppeIndex >= Truppe.Count)
                    truppeIndex = 0;
            }

            territoriIndex++;
            if (territoriIndex >= TerritoriContenuti.Count)
                territoriIndex = 0;
        }

        //if (territoriCount > 0)
        //{
        //    Console.WriteLine("Devi aggiungere tutte e 35 le truppe. Riparti da capo:");
        //    ResetTerritori();
        //    AggiungiTruppeIniziali();
        //}
    }

    private void ResetTerritori()
    {
        foreach (Territorio territorio in TerritoriContenuti)
        {
            territorio.Truppe.Clear();
        }
    }






}


