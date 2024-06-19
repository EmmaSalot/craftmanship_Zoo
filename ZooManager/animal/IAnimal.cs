public interface IAnimal
{
    int Id { get; set; }
    string Nom { get; set; }
    string Espece { get; set; }
    int Age { get; set; }
    IEnclos Enclos { get; set; }
}