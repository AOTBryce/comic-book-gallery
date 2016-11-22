using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {

        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {

                Id = 1,
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

            },
                    new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHTML = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { name = "Dan Slott", role = "Script" },
                    new Artist() { name = "Marcos Martin", role = "Pencils" },
                    new Artist() { name = "Marcos Martin", role = "Inks" },
                    new Artist() { name = "Muntsa Vicente", role = "Colors" },
                    new Artist() { name = "Joe Caramagna", role = "Letters" }
                },
                favorite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHTML = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { name = "Jeff Smith", role = "Script" },
                    new Artist() { name = "Jeff Smith", role = "Pencils" },
                    new Artist() { name = "Jeff Smith", role = "Inks" },
                    new Artist() { name = "Jeff Smith", role = "Letters" }
                },
                favorite = false
            }
    };

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBook GetComicBook(int id)
        {

            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }

            return comicBookToReturn;
        }

    }
}