public class Visite : IVisite
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan HeureDebut { get; set; }
    public TimeSpan HeureFin { get; set; }
    public List<IEnclos> Enclos { get; set; } = new List<IEnclos>();

    public bool EstValide()
    {
        return Enclos.Count <= 5;
    }
}