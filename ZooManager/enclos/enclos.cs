public class Enclos : IEnclos
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public Taille Taille { get; set; }
    public List<Espece> EspecesPermises { get; set; } = new List<Espece>();
    public List<IAnimal> Animaux { get; set; } = new List<IAnimal>();

    public bool PeutAccueillir(IAnimal animal)
    {
        return EspecesPermises.Contains(animal.Espece);
    }

    public bool EstVide => !Animaux.Any();
}