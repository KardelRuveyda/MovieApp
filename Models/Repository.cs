using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static  class Repository
    {
        private static List<Movie>  _movies = null;

        static Repository (){
            _movies = new List<Movie>()
            {
                new Movie(){
                    Id=1,
                    Name ="Love and Pride",
                    Description ="Romantic",
                    ImageUrl ="1.jpg"
                },

                                new Movie(){
                    Id=2,
                    Name ="Hunger Games",
                    Description ="Fantastic",
                    ImageUrl ="2.jpg"
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
                    ImageUrl ="4.jpg"
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