using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreMoviesForVue.DTOs;
using EFCoreMoviesForVue.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMoviesForVue.Controllers
{
    [ApiController]
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenresController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<GenreDTO>> GetAll()
        {
            var genres = await context.Genres
                .ProjectTo<GenreDTO>(mapper.ConfigurationProvider)
                .ToListAsync();

            return genres;

        }
    }
}
