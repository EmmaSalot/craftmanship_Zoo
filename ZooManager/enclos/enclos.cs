public class Enclos
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Taille { get; set; } // Petit, Moyen, Grand
    public List<string> EspecesPermises { get; set; }
    public List<Animal> Animaux { get; set; } = new List<Animal>();

    public bool PeutAccueillir(Animal animal)
    {
        return EspecesPermises.Contains(animal.Espece);
    }
}
