public interface IEnclos
{
    int Id { get; set; }
    string Nom { get; set; }
    Taille Taille { get; set; }
    List<Espece> EspecesPermises { get; set; }
    List<IAnimal> Animaux { get; set; }
    bool PeutAccueillir(IAnimal animal);
    bool EstVide { get; }
}