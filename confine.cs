public class Confine
{
    public int IdTerritorio { get; set; }
    public List<int> TerritoriConfinanti { get; set; }

    public Confine(int idTerritorio, List<int> territoriConfinanti)
    {
        IdTerritorio = idTerritorio;
        TerritoriConfinanti = territoriConfinanti;
    }
}