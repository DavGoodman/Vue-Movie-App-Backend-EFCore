using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Diagnostics.Metrics;
using EFCoreMoviesForVue.DTOs;

namespace EFCoreMoviesForVue.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MoviesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<MovieDTO>> GetAll()
        {
            var movies = await context.Movies
                .ProjectTo<MovieDTO>(mapper.ConfigurationProvider)
                .ToListAsync();


            return movies;

        }

        [HttpGet("MovieById/{id:int}")]
        public async Task<ActionResult<MovieDTO>> Get(int id)
        {
            var movie = await context.Movies
                .ProjectTo<MovieDTO>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (movie == null) return NotFound();

            return movie;

        }
    }
}
