using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static  class MovieRepository
    {
        private static List<Movie>  _movies = null;

        static MovieRepository (){
            _movies = new List<Movie>()
            {
                new Movie(){
                    Id=1,
                    Name ="Love and Pride",
                    Description ="Romantic",
                    ImageUrl ="1.jpg",
                    CategoryId = 1
                },

                                new Movie(){
                    Id=2,
                    Name ="Hunger Games",
                    Description ="Fantastic",
                    ImageUrl ="2.jpg",
                    CategoryId = 2
                },
                                new Movie(){
                    Id=3,
                    Name ="Social Network",
                    Description ="Software",
                    ImageUrl ="3.jpg"
                },
                                new Movie(){
                    Id=4,
                    Name ="Lara Croft Tomb Raider",
                    Description ="Action",
                    ImageUrl ="4.jpg",
                    CategoryId=3
                }
            };
        }

        public static List<Movie> Movies {
            get{
                return _movies;
            }
        }

        public static void AddMovie(Movie entity){
            _movies.Add(entity);
        }

        public static Movie GetById(int id){
            return _movies.FirstOrDefault(p => p.Id == id);
        }
    }
}