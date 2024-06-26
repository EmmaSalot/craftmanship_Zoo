public class Zoo : IZoo
{
    private List<IAnimal> animaux = new List<IAnimal>();
    private List<IEnclos> enclos = new List<IEnclos>();
    private List<IVisite> visites = new List<IVisite>();

    public void AjouterEnclos(IEnclos enclos)
    {
        this.enclos.Add(enclos);
    }

    public void ModifierEnclos(IEnclos enclos)
    {
        var enclosExist = this.enclos.FirstOrDefault(e => e.Id == enclos.Id);
        if (enclosExist != null)
        {
            enclosExist.Nom = enclos.Nom;
            enclosExist.Taille = enclos.Taille;
            enclosExist.EspecesPermises = enclos.EspecesPermises;
        }
    }

    public void SupprimerEnclos(int enclosId)
    {
        var enclosExist = this.enclos.FirstOrDefault(e => e.Id == enclosId);
        if (enclosExist != null && enclosExist.EstVide)
        {
            this.enclos.Remove(enclosExist);
        }
    }

    public List<IEnclos> ObtenirEnclos()
    {
        return enclos;
    }

    public void AjouterAnimal(IAnimal animal, IEnclos enclos)
    {
        if (enclos.PeutAccueillir(animal))
        {
            enclos.Animaux.Add(animal);
        }
    }

    public void ModifierAnimal(IAnimal animal)
    {
        var animalExist = this.animaux.FirstOrDefault(a => a.Id == animal.Id);
        if (animalExist != null)
        {
            animalExist.Nom = animal.Nom;
            animalExist.Espece = animal.Espece;
            animalExist.DateNaissance = animal.DateNaissance;
        }
    }

    public void SupprimerAnimal(int animalId)
    {
        var animalExist = this.animaux.FirstOrDefault(a => a.Id == animalId);
        if (animalExist != null)
        {
            this.animaux.Remove(animalExist);
        }
    }

    public List<IAnimal> ObtenirAnimaux()
    {
        return animaux;
    }

    public void AjouterVisite(IVisite visite)
    {
        if (visite.EstValide())
        {
            this.visites.Add(visite);
        }
    }

    public void ModifierVisite(IVisite visite)
    {
        var visiteExist = this.visites.FirstOrDefault(v => v.Id == visite.Id);
        if (visiteExist != null && visite.EstValide())
        {
            visiteExist.Date = visite.Date;
            visiteExist.HeureDebut = visite.HeureDebut;
            visiteExist.HeureFin = visite.HeureFin;
            visiteExist.Enclos = visite.Enclos;
        }
    }

    public void AnnulerVisite(int visiteId)
    {
        var visiteExist = this.visites.FirstOrDefault(v => v.Id == visiteId);
        if (visiteExist != null)
        {
            this.visites.Remove(visiteExist);
        }
    }

    public List<IVisite> ObtenirVisites()
    {
        return visites;
    }
}