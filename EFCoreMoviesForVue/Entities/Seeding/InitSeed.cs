using Microsoft.EntityFrameworkCore;

namespace EFCoreMoviesForVue.Entities.Seeding
{
    public class InitSeed
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            var action = new Genre { Id = 1, Name = "Action" };
            var animation = new Genre { Id = 2, Name = "Animation" };
            var comedy = new Genre { Id = 3, Name = "Comedy" };
            var scienceFiction = new Genre { Id = 4, Name = "ScienceFiction" };
            var drama = new Genre { Id = 5, Name = "Drama" };
            var adventure = new Genre { Id = 6, Name = "Adventure" };
            var superHero = new Genre { Id = 7, Name = "Super Hero" };

            modelBuilder.Entity<Genre>().HasData(action, animation, comedy, scienceFiction, drama, superHero, adventure);


            var spiderMan = new Movie
            {
                Id = 1,
                Title = "Spider-Man 2002",
                ImgUrl =
                    "https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_FMjpg_UX1000_.jpg",
                Synopsis =
                    "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
            };

            var aceVentura = new Movie
            {
                Id = 2,
                Title = "Ace Ventura: Pet Detective 1994",
                ImgUrl =
                    "https://m.media-amazon.com/images/M/MV5BYmVhNmFmOGYtZjgwNi00ZGQ0LThiMmQtOGZjMDUzNzJhMGIzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                Synopsis =
                    "A goofy detective specializing in animals goes in search of the missing mascot of the Miami Dolphins.",
            };

            var starWarsANewHope = new Movie
            {
                Id = 3,
                Title = "Star Wars: Episode IV - A New Hope 1977",
                ImgUrl =
                    "https://cdn2.penguin.com.au/covers/original/9781473544888.jpg",
                Synopsis =
                    "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.",
            };

            var theDarkKnight = new Movie
            {
                Id = 4,
                Title = "The Dark Knight 2008",
                ImgUrl =
                    "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UX1000_.jpg",
                Synopsis =
                    "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
            };

            var theMatrix = new Movie
            {
                Id = 5,
                Title = "The Matrix 1999",
                ImgUrl =
                    "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                Synopsis =
                    "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
            };

            modelBuilder.Entity<Movie>().HasData(spiderMan, aceVentura, starWarsANewHope, theDarkKnight, theMatrix);


            var spiderManAction = new MovieGenre { MovieId = 1, GenreId = 1 };
            var spiderManSuperHero = new MovieGenre { MovieId = 1, GenreId = 7 };

            var aceVenturaComedy = new MovieGenre { MovieId = 2, GenreId = 3 };

            var starWarsANewHopeAction = new MovieGenre { MovieId = 3, GenreId = 1 };
            var starWarsANewHopeAdventure = new MovieGenre { MovieId = 3, GenreId = 6 };
            var starWarsANewHopeScienceFiction = new MovieGenre { MovieId = 3, GenreId = 4 };

            var theDarkKnightAction = new MovieGenre { MovieId = 4, GenreId = 1 };
            var theDarkKnightDrama = new MovieGenre { MovieId = 4, GenreId = 5 };
            var theDarkKnightSuperHero = new MovieGenre { MovieId = 4, GenreId = 7 };

            var theMatrixAction = new MovieGenre { MovieId = 5, GenreId = 1 };
            var theMatrixScienceFiction = new MovieGenre { MovieId = 5, GenreId = 4 };

            modelBuilder.Entity<MovieGenre>().HasData(spiderManAction, spiderManSuperHero, aceVenturaComedy,
                               starWarsANewHopeAction, starWarsANewHopeAdventure, starWarsANewHopeScienceFiction,
                                              theDarkKnightAction, theDarkKnightDrama, theDarkKnightSuperHero, theMatrixAction, theMatrixScienceFiction);

        }

    }
}
