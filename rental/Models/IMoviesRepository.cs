using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rental.Models
{
    public interface IMoviesRepository
    {
        public ViewResult Index();
        public ViewResult New();
        public ActionResult Edit(int id);
        public ActionResult Details(int id);
        public ActionResult Random();
        public ActionResult Save(Movie movie);

    }
}
