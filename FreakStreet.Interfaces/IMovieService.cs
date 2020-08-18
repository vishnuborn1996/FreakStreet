using FreakStreet.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreakStreet.Interfaces
{
    public interface IMovieService
    {
        /// <summary>
        /// Gets the movies.
        /// </summary>
        /// <returns></returns>
        List<MovieModel> GetMovies();

        /// <summary>
        /// Gets the movies asynchronously.
        /// </summary>
        /// <returns></returns>
        Task<List<MovieModel>> GetMoviesAsync();

        /// <summary>
        /// Gets the movies by identifier asynchronously.
        /// </summary>
        /// <returns></returns>
        Task<MovieModel> GetMoviesByIdAsync(Guid id);
       
        /// <summary>
        /// Gets the movies by identifier.
        /// </summary>
        /// <returns></returns>
        MovieModel GetMoviesById(Guid id);


    }
}