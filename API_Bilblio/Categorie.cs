namespace API_Biblio
{
    public class Categorie
    {
        private int idCat;
        private string name;
        private int count;
        private string description;
        private string image;

        public Categorie(int idCat, string name, int count, string description, string image)
        {
            this.IdCat = idCat;
            this.Name = name;
            this.Count = count;
            this.Description = description;
            this.Image = image;
        }

        public int IdCat { get => idCat; set => idCat = value; }
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
    }
}
