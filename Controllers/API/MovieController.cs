
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using MovieRental.Dtos;
using MovieRental.Models;

namespace MovieRental.Controllers.API
{
    public class MovieController : ApiController
    {
        private MyDbContext _context;

        public MovieController()
        {
            _context = new MyDbContext();
        }

        //GET /movie/getall
        [HttpGet]
        public IEnumerable<MovieDto> GetAll()
        {
            return _context.Movies.ToList().Select(m => Mapper.Map<Movie, MovieDto>(m));
        }

        //GET /movie/get/1
        [HttpGet]
        public MovieDto Get(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Movie, MovieDto>(movie);
        }

        //POST /movie/new
        [HttpPost]
        public MovieDto Add(MovieDto movieDto)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return movieDto;
        }

        //PUT /movie/update
        [HttpPut]
        public MovieDto Update(int id , MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.Single(m => m.Id == id);
            
            if(movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

           Mapper.Map<MovieDto, Movie>(movieDto, movieInDb);

            /*if (!string.IsNullOrEmpty(movieDto.Name) && !movieDto.Name.Equals(movieInDb.Name))
                movieInDb.Name = movieDto.Name;

            if (movieDto.GenreId != movieInDb.GenreId)
            {
                movieInDb.GenreId = movieDto.GenreId;
            }
            if (movieDto.NumberOfStock !=  movieInDb.NumberOfStock)
                movieInDb.NumberOfStock = movieDto.NumberOfStock;

            if (movieDto.ReleaseDate != movieInDb.ReleaseDate)
                movieInDb.ReleaseDate = movieDto.ReleaseDate;
*/
            _context.SaveChanges();

            return movieDto;
        }

        //DELETE /movie/delete/1
        [HttpDelete]
  
        public void Delete(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movie);

            _context.SaveChanges();
        }
    }
}