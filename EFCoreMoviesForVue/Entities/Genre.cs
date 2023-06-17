namespace EFCoreMoviesForVue.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
    }
}
