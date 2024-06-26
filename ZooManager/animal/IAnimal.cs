public interface IAnimal
{
    int Id { get; set; }
    string Nom { get; set; }
    Espece Espece { get; set; }
    DateTime DateNaissance { get; set; }
    int GetAge();
}