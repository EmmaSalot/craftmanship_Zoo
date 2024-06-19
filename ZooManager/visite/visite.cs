public class Visite
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan HeureDebut { get; set; }
    public TimeSpan HeureFin { get; set; }
    public List<Enclos> Enclos { get; set; }

    public bool EstValide()
    {
        return Enclos.Count <= 5;
    }
}
