using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakStreet.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FreakStreet.Interfaces;
using MongoDB.Driver;

namespace FreakStreet.Server.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieController"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var movies = await movieService.GetMoviesAsync();

            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var movie =  this.movieService.GetMoviesById(id);
            return  Ok(movie);
        }
    }
}