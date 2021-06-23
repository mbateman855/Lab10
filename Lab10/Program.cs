using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a movie category. (animated, horror, scifi, drama)");
            Console.WriteLine("You can also select 1-4 to choose a category.");
            Console.WriteLine("1.) animated" + "\n2.) horror" + "\n3.) scifi" + "\n4.) drama\n");
            MenuCheck(Console.ReadLine());
        }

        static void MenuCheck(string input)
        {
            if (int.TryParse(input, out int validInput) == true)
            {
                CategoryMenu(validInput);
            }
            else
            {
                InputValidation(input);
            }
        }

        static void CategoryMenu(int input)
        {           
            if (input == 1)
            {
                MovieList("animated");
            }
            else if (input == 2)
            {
                MovieList("horror");
            }
            else if (input == 3)
            {
                MovieList("scifi");
            }
            else if (input == 4)
            {
                MovieList("drama");
            }
            else
            {
                return;
            }

        }

        static void InputValidation(string inputCheck)
        {
            if (inputCheck == null)
            {
                Console.WriteLine("Not a valid category, please select animated, horror, scifi, or drama.");
                MenuCheck(Console.ReadLine());
            }

            string input = inputCheck.ToLower();
            Regex blankCheck = new Regex(@"\s+");            

            if (blankCheck.IsMatch(input) == false && input != string.Empty)
            {
                if (input == "animated" || input == "horror" || input == "scifi" || input == "drama")
                {
                    MovieList(input);
                }
                else
                {
                    Console.WriteLine("Not a valid category, please select animated, horror, scifi, or drama.");
                    InputValidation(Console.ReadLine());
                }
                
            }
            else
            {
                Console.WriteLine("Input cannot be blank, please enter a movie category.");
                InputValidation(Console.ReadLine());
            }
        }

        static void Repeater()
        {
            Console.WriteLine("Would you like to continue? Y/N");
            string repeatCheck = Console.ReadLine();

            if (repeatCheck == null)
            {
                Console.WriteLine("Please indicate Y or N.");
                Repeater();
                return;
            }
            string repeat = repeatCheck.ToLower();

            if (repeat == "y")
            {
                Console.WriteLine("Please enter a movie category. (animated, horror, scifi, drama)");
                Console.WriteLine("You can also select 1-4 to choose a category.");
                Console.WriteLine("1.) animated" + "\n2.) horror" + "\n3.) scifi" + "\n4.) drama\n");
                MenuCheck(Console.ReadLine());
            }
            else if(repeat == "n")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Please indicate Y or N.");
                Repeater();
            }
        }

        static void MovieList(string inputCategory)
        {
            List<Movie> movies = new List<Movie>();
            //animated, drama, horror, scifi
            var movie1 = new Movie("The Emperor's New Groove", "animated");
            var movie2 = new Movie("Prometheus", "scifi");
            var movie3 = new Movie("Hitch", "drama");
            var movie4 = new Movie("Midsommar", "horror");
            var movie5 = new Movie("101 Dalmations", "animated");
            var movie6 = new Movie("Pacific Rim", "scifi");
            var movie7 = new Movie("It", "horror");
            var movie8 = new Movie("The Godfather", "drama");
            var movie9 = new Movie("Shrek", "animated");
            var movie10 = new Movie("Stand By Me", "drama");

            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            movies.Add(movie8);
            movies.Add(movie9);
            movies.Add(movie10);

            foreach(var movie in movies)
            {
                if (movie.Category == inputCategory)
                {
                    Console.WriteLine(movie.Title);
                }
            }

            Repeater();

            //Below, trying to figure out how to sort a list by a property...

            //List<Movie> sortedMovies = new List<Movie>();

            //foreach (var movie in movies)
            //{
            //    if (movie.Category == inputCategory)
            //    {
            //        sortedMovies.Add(movie);
            //    }
            //}
            //sortedMovies.Sort((s1, s2) => s1.CompareTo(s2));
            //foreach (var movie in sortedMovies)
            //{
            //    Console.WriteLine(movie.Title);
            //}
        }
    }
}
