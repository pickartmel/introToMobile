using System;
using System.IO;
using MovieApp.Custom;
using MovieApp.Droid.Custom;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Droid))]
namespace MovieApp.Droid.Custom
{
    public class SQLite_Droid : ISQLite
    {
        public SQLite_Droid()
        {

        }

        public SQLiteConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var dbPath = Path.Combine(libraryPath, "MyDatabase.db3");

            return new SQLiteConnection(new SQLitePlatformAndroid(), dbPath);
        }
    }

}