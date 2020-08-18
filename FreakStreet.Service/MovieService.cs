using FreakStreet.Shared;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using FreakStreet.Interfaces;
using System.Threading.Tasks;

namespace FreakStreet.Service
{
    public class MovieService : IMovieService
    {
        /// <summary>
        /// The movies
        /// </summary>
        private readonly IMongoCollection<MovieModel> _movies;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieService"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public MovieService(IMovieStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _movies = database.GetCollection<MovieModel>(settings.MoviesCollectionName);
        }

        /// <summary>
        /// Gets the movies asynchronously.
        /// </summary>
        /// <returns></returns>
        public Task<List<MovieModel>> GetMoviesAsync()
        {
            return this._movies.Find(it => true).ToListAsync();
        }

        /// <summary>
        /// Gets the movies.
        /// </summary>
        /// <returns></returns>
        public List<MovieModel> GetMovies()
        {
            return this._movies.Find(it => true).ToList();
        }


        /// <summary>
        /// Gets the movies by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public MovieModel GetMoviesById(Guid id)
        {
            return this._movies.Find(it => it.Id.Equals(id)).FirstOrDefault();
        }

        /// <summary>
        /// Gets the movies by identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task<MovieModel> GetMoviesByIdAsync(Guid id)
        {
            return this._movies.Find<MovieModel>(it => it.Id == id).FirstOrDefaultAsync();
        }
    }
}
