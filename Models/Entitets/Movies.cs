namespace MovieDemo10.Models.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public float Rating { get; set; }

    }
}
