namespace ZooManager.Tests;

public class UnitTest1
{

    [Fact]
    public void AjouterUnEnclos_DoitAjouterUnEnclos()
    {
        var zoo = new Zoo();
        var enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = "Grand",
            EspecesPermises = new List<string> { "Lion" }
        };

        zoo.AjouterEnclos(enclos);

        Assert.True(zoo.ObtenirEnclos().Contains(enclos));
    }
}