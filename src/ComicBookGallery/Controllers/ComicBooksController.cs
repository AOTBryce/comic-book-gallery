using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            var comicBook = new ComicBook()
            {

                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {

                    new Artist() {name = "Dan Slott", role = "Scripts" },
                    new Artist() {name = "Humberto Ramos", role = "Pencils" },
                    new Artist() {name = "Victor Olazaba", role = "Inks" },
                    new Artist() {name = "Edgar Delgado", role = "Colors" },
                    new Artist() {name = "Chris Eliopoulos", role = "Letters" },

                }

            };

            return View(comicBook);

        }
    }
}