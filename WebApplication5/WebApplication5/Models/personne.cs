




namespace WebApplication5.Models

{
    public class personne
    {
        string Guid  prenomID { get; set; }
        string nom { get; set; }
        string email { get; set; }
        string description { get; set;}
    

        public personne(string prenomID, string nom, string email, string description)
        {
            prenomID = prenomID;
            nom = nom;
            email = email;
            description = description;

        }
    }
}
