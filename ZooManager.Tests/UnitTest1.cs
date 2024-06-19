namespace ZooManager.Tests;

public class UnitTest1
{
    [Fact]
    public void AjouterAnimal_DoitAjouterAnimal_SiEnclosPeutAccueillir()
    {
        // Arrange
        var zoo = new Zoo();
        var enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = "Grand",
            EspecesPermises = new List<string> { "Lion" }
        };
        zoo.AjouterEnclos(enclos);

        var animal = new Animal
        {
            Id = 1,
            Nom = "Simba",
            Espece = "Lion",
            Age = 5,
            Enclos = enclos
        };

        // Act
        zoo.AjouterAnimal(animal);

        // Assert
        Assert.True(zoo.ObtenirAnimaux().Contains(animal));
        Assert.True(enclos.Animaux.Contains(animal));
    }
}