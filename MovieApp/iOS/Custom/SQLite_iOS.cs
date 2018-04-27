using System;
using System.IO;
using MovieApp.Custom;
using MovieApp.iOS.Custom;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace MovieApp.iOS.Custom
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
            
        }

        public SQLiteConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var dbPath = Path.Combine(libraryPath, "MyDatabase.db3");

            return new SQLiteConnection(new SQLitePlatformIOS(), dbPath);
        }
    }
}
