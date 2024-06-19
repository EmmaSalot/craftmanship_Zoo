public interface IEnclos
{
    int Id { get; set; }
    string Nom { get; set; }
    string Taille { get; set; }
    List<string> EspecesPermises { get; set; }
    List<IAnimal> Animaux { get; set; }
    bool PeutAccueillir(IAnimal animal);
    bool EstVide { get; }
}