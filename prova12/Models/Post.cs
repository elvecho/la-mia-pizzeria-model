namespace laMiaPizzeria.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int Prezzo { get; set; }
        public string Title { get; set; }
public string description { get; set; }
       public string image { get; set; }

        public Post()
        {

        }
        public Post( int Id , string Title, string description, string image)
        {
            this.Id = Id;
            
            this.Title = Title;
            this.description = description;
            this.image = image;
        }
       
    }
}
