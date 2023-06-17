namespace EFCoreMoviesForVue.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Synopsis { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
    }
}
