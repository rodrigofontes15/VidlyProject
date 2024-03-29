﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {

        private ApplicationDbContext _context;

        // POST /api/rentals
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovie)]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id));


            foreach (var movie in movies)
            {
                if (movie.NumberAvaliable == 0)
                    return BadRequest("Not Avaliable");

                movie.NumberAvaliable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();


            return Ok();
                                 
        }
    }
}
