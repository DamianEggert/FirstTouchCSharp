using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private string rating;

        public Book()
        {

        }

        public Book(string aTitle, string aAuthor, int aPages, string aRating)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "good" || value == "bad")
                {
                    rating = value;
                }
                else
                {
                    rating = "anyway good";
                }
            }
        }

    }
}
