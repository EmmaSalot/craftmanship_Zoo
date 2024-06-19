public class Enclos : IEnclos
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Taille { get; set; }
    public List<string> EspecesPermises { get; set; } = new List<string>();
    public List<IAnimal> Animaux { get; set; } = new List<IAnimal>();

    public bool PeutAccueillir(IAnimal animal)
    {
        return EspecesPermises.Contains(animal.Espece);
    }

    public bool EstVide => !Animaux.Any();
}