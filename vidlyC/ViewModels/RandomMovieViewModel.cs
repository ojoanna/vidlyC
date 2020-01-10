using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyC.Models;

namespace vidlyC.ViewModels
{
    public class RandomMovieViewModel
    { 
 
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
    }
}