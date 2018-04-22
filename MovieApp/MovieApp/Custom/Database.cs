using System;
using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;
using SQLite.Net;
using Xamarin.Forms;



namespace MovieApp.Custom
{
    public class Database
    {
        SQLiteConnection database;
        static object locker = new object(); //create a locker
        public Database()
        {
            //get connection
            database = DependencyService.Get<ISQLite>().GetConnection();
            //create tables
            database.CreateTable<Movie>();

        }

        public void SaveMovie(Movie movie)
        {
            lock (locker)//lock it so no one can insert or pull while this is going on

            {
                database.Insert(movie);
            }
        }
        public IEnumerable<Movie> GetMovies()
        {
            lock (locker)//forces concurrency 
                         // return database.Query("Select * from [Movie]"); can do it this way
                return (from db in database.Table<Movie>() select db).ToList(); //use linq to sql
        }
    }
}
