using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakStreet.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreakStreet.Server.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IHostingEnvironment env;

        public List<MovieModel> Movies { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieController"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public MovieController(IHostingEnvironment environment)
        {
            this.env = environment;
            this.Movies = new List<MovieModel>()
            {
                new MovieModel()
                {
                    Id= new Guid("cb290e6d-d293-46ff-bf78-103dbf35a976"),
                    Description="Schmidt and Jenko are high school friends who go on to become police officers. The two friends go undercover as students in order to bust a drug ring and find the source of a synthetic drug.",
                    PrimaryImg="http://localhost:52322/images/21Jumpstreet.jpg",
                    Title="21 Jump Street",
                    PrimaryVid= "https://www.youtube.com/embed/RLoKtb4c4W0"
                },
                new MovieModel()
                {
                    Id= new Guid("fd4f4bda-40ec-482e-b0b9-20bcd6964e35"),
                    Description="Five high school students, all with different mindsets, face detainment in their school library on a Saturday morning. As time passes by, their egos fade and they become close buddies.",
                     PrimaryImg="http://localhost:52322/images/breakfastclub.jpg",
                    Title="Breakfast club",
                    PrimaryVid="https://www.youtube.com/embed/BSXBvor47Zs"
                },
                new MovieModel()
                {
                    Id=new Guid("c283ba16-391b-4cc9-b9cf-877cec1b44c4"),
                    Description="Hoping to spend Christmas with his estranged wife, detective John McClane arrives in LA. However, he learns about a hostage situation in an office building and his wife is one of the hostages.",
                     PrimaryImg="http://localhost:52322/images/die-hard.jpg",
                    Title="Die Hard",
                    PrimaryVid="https://www.youtube.com/embed/jaJuwKCmJbY"
                },
            };
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(this.Movies.FirstOrDefault(it=> it.Id== id));
        }
    }
}