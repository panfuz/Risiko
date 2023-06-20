public class Esercito
{
    public string id { get; set; }
    public int id_giocatore { get; set; }

    public List<int> truppe { get; set; }

    public Esercito(string Id, int Id_giocatore, List<int> Truppe)
    {
        id = Id;
        id_giocatore = Id_giocatore;
        truppe = Truppe;
    }
}
