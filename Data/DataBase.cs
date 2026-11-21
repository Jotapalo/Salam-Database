using System;
using System.Data.SQLite;
using System.IO;

namespace Salam_Database.Data
{
    public static class Database
    {
        private static readonly string DataFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        private static readonly string DatabasePath =
           "E:\\proyectos\\SALAM db prospect\\Salam Database\\Data\\negocio.db"; //parche temporal para que funcione con la base de datos
        /*Path.Combine(DataFolder, "negocio.db");*/



        private static readonly string ConnectionString =
            "Data Source=" + DatabasePath + ";Version=3;Foreign Keys=True;Encoding=UTF-8";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection =
                new SQLiteConnection(ConnectionString);

            connection.Open();

            return connection;
        }

        public static void Initialize()
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }

            if (!File.Exists(DatabasePath))
            {
                SQLiteConnection.CreateFile(DatabasePath);

                using (SQLiteConnection connection = GetConnection())
                {
                    string script = File.ReadAllText(
                        Path.Combine(DataFolder, "database.sql"));

                    using (SQLiteCommand command =
                        new SQLiteCommand(script, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}