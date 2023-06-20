public class Esercito
{
    public string id { get; set; }
    public string id_giocatore { get; set; }

    public List<int> truppe { get; set; }

    public Esercito(string Id, string Id_giocatore, List<int> Truppe)
    {
        id = Id;
        id_giocatore = Id_giocatore;
        truppe = Truppe;
    }
}
