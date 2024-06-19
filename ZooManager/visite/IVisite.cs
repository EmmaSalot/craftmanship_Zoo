public interface IVisite
{
    int Id { get; set; }
    DateTime Date { get; set; }
    TimeSpan HeureDebut { get; set; }
    TimeSpan HeureFin { get; set; }
    List<IEnclos> Enclos { get; set; }
    bool EstValide();
}