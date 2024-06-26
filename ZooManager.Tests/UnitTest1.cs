public class UnitTestZoo
{
    [Fact]
    public void AjouterUnEnclos_DoitAjouterUnEnclos()
    {
        IZoo zoo = new Zoo();
        IEnclos enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = Taille.Grande,
            EspecesPermises = new List<Espece> { Espece.Lion }
        };

        zoo.AjouterEnclos(enclos);

        Assert.True(zoo.ObtenirEnclos().Contains(enclos));
    }

    [Fact]
    public void PeutAccueillir_DoitRetournerVraiSiEspecePermise()
    {
        IEnclos enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = Taille.Grande,
            EspecesPermises = new List<Espece> { Espece.Lion }
        };

        IAnimal lion = new Animal
        {
            Id = 1,
            Nom = "Simba",
            Espece = Espece.Lion,
            Age = 5
        };

        Assert.True(enclos.PeutAccueillir(lion));
    }

    [Fact]
    public void PeutAccueillir_DoitRetournerFauxSiEspeceNonPermise()
    {
        IEnclos enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = Taille.Grande,
            EspecesPermises = new List<Espece> { Espece.Lion }
        };

        IAnimal girafe = new Animal
        {
            Id = 1,
            Nom = "Gigi",
            Espece = Espece.Girafe,
            Age = 5
        };

        Assert.False(enclos.PeutAccueillir(girafe));
    }

    [Fact]
    public void AjouterVisite_DoitAjouterUneVisite()
    {
        IZoo zoo = new Zoo();
        IVisite visite = new Visite
        {
            Id = 1,
            Date = DateTime.Now,
            HeureDebut = new TimeSpan(8, 0, 0),
            HeureFin = new TimeSpan(12, 0, 0),
            Enclos = new List<IEnclos>
            {
                new Enclos { Id = 1, Nom = "Enclos Grands Félins", Taille = Taille.Grande, EspecesPermises = new List<Espece> { Espece.Lion }}
            }
        };

        zoo.AjouterVisite(visite);

        Assert.True(zoo.ObtenirVisites().Contains(visite));
    }

    [Fact]
    public void EstValide_DoitRetournerVraiSiMoinsDe5EnclosLorsDeLaPlanificationDeLaVisite()
    {
        IVisite visite = new Visite
        {
            Id = 1,
            Date = DateTime.Now,
            HeureDebut = new TimeSpan(8, 0, 0),
            HeureFin = new TimeSpan(12, 0, 0),
            Enclos = new List<IEnclos>
            {
                new Enclos { Id = 1, Nom = "Enclos Grands Félins", Taille = Taille.Grande, EspecesPermises = new List<Espece> { Espece.Lion }}
            }
        };

        Assert.True(visite.EstValide());
    }

    [Fact]
    public void AjouterAnimal_DoitAjouterUnAnimalDansUnEnclos()
    {
        IZoo zoo = new Zoo();
        IEnclos enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = Taille.Grande,
            EspecesPermises =  new List<Espece> { Espece.Lion }
        };
        IAnimal lion = new Animal
        {
            Id = 1,
            Nom = "Simba",
            Espece = Espece.Lion,
            Age = 5
        };
        zoo.AjouterEnclos(enclos);

        zoo.AjouterAnimal(lion, enclos);

        Assert.True(enclos.Animaux.Contains(lion));
    }

    [Fact]
    public void SupprimerEnclos_DoitSupprimerUnEnclosVide()
    {
        IZoo zoo = new Zoo();
        IEnclos enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = Taille.Moyenne,
            EspecesPermises = new List<Espece> { Espece.Lion }
        };
        zoo.AjouterEnclos(enclos);

        zoo.SupprimerEnclos(enclos.Id);

        Assert.False(zoo.ObtenirEnclos().Contains(enclos));
    }

    [Fact]
    public void SupprimerEnclos_NeDoitPasSupprimerUnEnclosNonVide()
    {
        IZoo zoo = new Zoo();
        IEnclos enclos = new Enclos
        {
            Id = 1,
            Nom = "Enclos Grands Félins",
            Taille = Taille.Grande,
            EspecesPermises = new List<Espece> { Espece.Lion }
        };
        IAnimal lion = new Animal
        {
            Id = 1,
            Nom = "Simba",
            Espece = Espece.Lion,
            Age = 5
        };
        enclos.Animaux.Add(lion);
        zoo.AjouterEnclos(enclos);

        zoo.SupprimerEnclos(enclos.Id);

        Assert.True(zoo.ObtenirEnclos().Contains(enclos));
    }
}
