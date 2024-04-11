using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Jackson_Lydia
{
    internal class Game
    {
        // two public string fields one for title and one for genre
        public string title, genre;

        // a constructor with two string parameters, with default values
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        { 
            // sets the value for title and genre to titleParam and genreParam
            title = titleParam;
            genre = genreParam;
        }

    }
}
