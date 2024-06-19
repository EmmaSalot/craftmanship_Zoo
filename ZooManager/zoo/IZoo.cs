public interface IZoo
{
    void AjouterEnclos(IEnclos enclos);
    void ModifierEnclos(IEnclos enclos);
    void SupprimerEnclos(int enclosId);
    List<IEnclos> ObtenirEnclos();

    void AjouterAnimal(IAnimal animal);
    void ModifierAnimal(IAnimal animal);
    void SupprimerAnimal(int animalId);
    List<IAnimal> ObtenirAnimaux();

    void AjouterVisite(IVisite visite);
    void ModifierVisite(IVisite visite);
    void AnnulerVisite(int visiteId);
    List<IVisite> ObtenirVisites();
}