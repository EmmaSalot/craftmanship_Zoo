public class Animal : IAnimal
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Espece { get; set; }
    public int Age { get; set; }
    public IEnclos Enclos { get; set; }
}