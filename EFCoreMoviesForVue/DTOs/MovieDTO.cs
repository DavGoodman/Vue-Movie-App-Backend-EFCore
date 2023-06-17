namespace EFCoreMoviesForVue.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Synopsis { get; set; }
        public List<string> Genres { get; set; }
    }
}
