using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class ManageMovies
    {
        List<Movie> movies;
        public ManageMovies()
        {
            movies = new List<Movie>();
        }
        private int GenerateId()
        {
            if (movies.Count == 0)
                return 1;
            int id = movies[movies.Count - 1].Id;
            id++;
            return id;
        }

        public Movie CreateMovie()
        {
            Movie movie = new Movie();
            movie.Id = GenerateId();
            movie.TakeMovieDetails();
            return movie;
        }
        public int GetMovieIndexById(int id)
        {
            return movies.FindIndex(m => m.Id == id);//Lambda Expression

        }
        public Movie UpdateMovieName(int id, string name)
        {
            Movie movie = null;
            int idx = GetMovieIndexById(id);
            if (idx != -1)
            {
                movies[idx].Name = name;
                movie = movies[idx];
            }
            return movie;
        }
        private void PrintMovieById()
        {
            Console.WriteLine("please enter the movie id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            int idx = GetMovieIndexById(id);
            if (idx >= 0)
                PrintMovie(movies[idx]);
            else
                Console.WriteLine("No Such Movies");
        }
        void AddMovies()
        {
            int choice = 0;
            do
            {
                Movie movie = CreateMovie();
                movies.Add(movie);
                Console.WriteLine("Do you wish to add another movie? if YES enter any number other than 0. To exit enter o");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Not a correct input ");
                }
            } while (choice != 0);
        }

        public Movie UpdateMovieDuration(int id, double duration)
        {
            Movie movie = null;
            int idx = GetMovieIndexById(id);
            if (idx != 1)
            {
                movies[idx].Duration = duration;
                movie = movies[idx];
            }
            return movie;
        }

        public void PrintMovieById(int id)
        {
            int idx = GetMovieIndexById(id);
            if (idx != -1)
            {
                PrintMovie(movies[idx]);
            }
            else
            {
                Console.WriteLine("No such movies");
            }
        }

        public void printAllMovies()
        {
            if (movies.Count == 0)
                Console.WriteLine("NO movies Present");
            else
            {
                foreach (var item in movies)
                {
                    PrintMovie(item);
                }
            }
        }
        public void SortMovies()
        {
            if (movies.Count != 0)
                movies.Sort();
            else
                Console.WriteLine("no movoies to sort");

        }

        public void PrintMovie(Movie movie)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(movie);
            Console.WriteLine("------------------------------");
        }
        void UpdateMovie()
        {
            Console.WriteLine("Please enter the movie id for updation");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want to update nname or duration or both");
            string choice = Console.ReadLine();
            string name;
            double duration;
            switch (choice)
            {
                case "name":
                    Console.WriteLine("Please enter the new name");
                    name = Console.ReadLine();
                    UpdateMovieName(id, name);
                    break;
                case "duration":
                    Console.WriteLine("please enter the new duration for the movie");
                    while (!double.TryParse(Console.ReadLine(), out duration))
                    {
                        Console.WriteLine("Invalid entry for duration");
                    }
                    UpdateMovieDuration(id, duration);
                    break;
                case "both":
                    Console.WriteLine("Please enter the new name");
                    name = Console.ReadLine();
                    UpdateMovieName(id, name);
                    Console.WriteLine("please enter the new duration for the movie");
                    while (!double.TryParse(Console.ReadLine(), out duration))
                    {
                        Console.WriteLine("Invalid entry for duration");
                    }
                    UpdateMovieDuration(id, duration);
                    break;


            }

        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add a Movie");
                Console.WriteLine("2.Add a List of Movies");
                Console.WriteLine("3.Update the Movie");
                Console.WriteLine("4.Delete  the movie ");
                Console.WriteLine("5.Print Movie By id");
                Console.WriteLine("6.print all the Movie");
                Console.WriteLine("7.sort movie");
                Console.WriteLine("8.Exit the application");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Movie movie = CreateMovie();
                        movies.Add(movie);
                        break;
                    case 2:
                        AddMovies();
                        break;
                    case 3:
                        UpdateMovie();
                        break;
                    case 4:
                        DeleteMovie();
                        break;
                    case 5:
                        PrintMovieById();
                        break;
                    case 6:
                        printAllMovies();
                        break;
                    case 7:
                        SortMovies();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;




                }
            } while (choice != 8);
        }

        private void DeleteMovie()
        {
            Console.WriteLine("Please enter the movie id to be deleted");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                movies.RemoveAt(GetMovieIndexById(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs Something went wrong.please try again");
            }
        }


       // static void Main(string[] s)
       //{
       //     new ManageMovies().PrintMenu();
       //     Console.ReadKey();
       //}
    }

}

    

