using Microsoft.Data.Sqlite;

namespace TodoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // create a connection
            var connection = new SqliteConnection("Data Source=todo_database.db");

            // open the connection
            connection.Open();

            // create users command
            var createUsersCommand = connection.CreateCommand();
            createUsersCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS 'users' (
                    'id' INTEGER UNIQUE,
                    'first_name' TEXT NOT NULL DEFAULT '',
                    'last_name' TEXT NOT NULL DEFAULT '',
                    'email' TEXT NOT NULL,
                    'password' TEXT NOT NULL,
                    'is_admin' INTEGER NOT NULL DEFAULT 0,
                    PRIMARY KEY('id' AUTOINCREMENT)
                );
            ";

            // execute the create users table
            createUsersCommand.ExecuteNonQuery();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}