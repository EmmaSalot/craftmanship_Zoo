public class Animal : IAnimal
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public Espece Espece { get; set; }
    public DateTime DateNaissance { get; set; }
    
    public int GetAge()
    {
        return (int)(DateTime.Now - DateNaissance).TotalDays / 365;
    }

}