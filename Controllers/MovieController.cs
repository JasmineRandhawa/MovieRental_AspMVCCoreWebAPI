﻿
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using MovieRental.Models;
using System.Linq;
using MovieRental.ViewModels;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;

namespace MovieRental.Controllers
{
    public class MovieController : Controller
    {
        private readonly MyDbContext _context;
        List<Genre> dbGenreList = new List<Genre>();

        public MovieController()
        {
            _context = new MyDbContext();
            dbGenreList.AddRange(_context.Genres.ToList());
        }


        public ViewResult Index()
        {
            List<Movie> moviesList = _context.Movies.Include(m => m.Genre).ToList();
            return View("Index", moviesList);
        }

        public ViewResult New()
        {
            var viewModel = new MovieFormViewModel()
            {
                 Genres = dbGenreList
             
            };
            return View("AddUpdateMovie",viewModel);
        }

        public ViewResult Edit(int id)
        {
            Movie movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = dbGenreList
            };
            return View("AddUpdateMovie",viewModel);
        }

        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = dbGenreList
                };

                return View("AddUpdateMovie", viewModel);
            }
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberOfStock = movie.NumberOfStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

        public IActionResult Delete(int id)
        {
            Movie movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movie);

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

    }
}
