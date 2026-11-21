using System;
using System.Data.SQLite;
using System.IO;

namespace Salam_Database.Data
{
    public static class Database
    {
        private static readonly string ApplicationDataFolder =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "Salam Database");

        private static readonly string DatabasePath =
            Path.Combine(ApplicationDataFolder, "negocio.db");

        private static readonly string SourceDataFolder =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data");

        private static readonly string ScriptPath =
            Path.Combine(SourceDataFolder, "database.sql");

        private static readonly string ScriptPathSeed =
            Path.Combine(SourceDataFolder, "seed.sql");

        private static readonly string ConnectionString =
            "Data Source=" + DatabasePath +
            ";Version=3;Foreign Keys=True;Encoding=UTF-8;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection =
                new SQLiteConnection(ConnectionString);

            connection.Open();

            return connection;
        }

        public static void Initialize()
        {
            Directory.CreateDirectory(ApplicationDataFolder);

            if (File.Exists(DatabasePath))
            {
                return;
            }

            if (!File.Exists(ScriptPath))
            {
                throw new FileNotFoundException(
                    "No se encontró el script de creación de la base de datos.",
                    ScriptPath);
            }
            if (!File.Exists(ScriptPathSeed))
            {
                throw new FileNotFoundException(
                    "No se encontró el script de semilla de la base de datos.",
                    ScriptPathSeed);

            }

            SQLiteConnection.CreateFile(DatabasePath);

            using (SQLiteConnection connection = GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(
                File.ReadAllText(ScriptPath),
                connection))
            {
                command.ExecuteNonQuery();
            }

            using (SQLiteConnection connection = GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(
                File.ReadAllText(ScriptPathSeed),
                connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}