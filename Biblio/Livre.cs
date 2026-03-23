namespace Biblio
{
    public class Livre
    {
        private int idLivre;
        private string name;
        private string description;
        private int idCat;

        public Livre(int idLivre, string name, string description, int idCat)
        {
            this.IdLivre = idCat;
            this.Name = name;
            this.Description = description;
            this.IdCat = idCat;
        }

        public int IdLivre { get => idLivre; set => idLivre = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int IdCat { get => idCat; set => idCat = value; }

        public override string ToString()
        {
            return (this.Name + " " + this.Description);
        }
    }
}
