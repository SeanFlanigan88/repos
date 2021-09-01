using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_10
{
   class Movie
   {
        public Movie(string title, MovieType category)
        {
            _title = title;
            _category = category;
        }

        private MovieType _category = MovieType.Unknown;

        public MovieType Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        private string _title = string.Empty;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
   }
}
