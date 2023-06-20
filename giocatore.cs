public class Giocatore
{
    string id { get; set; }
    string nome { get; set; }

    public Giocatore(string Id, string Nome)
    {
        id = Id;
        nome = Nome;
    }
}