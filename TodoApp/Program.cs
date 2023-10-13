using Microsoft.Data.Sqlite;
using TodoApp.Data;

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
            var dbHelper = DBHelper.Instance;

            User user = new User();
            user.FirstName = "John";
            user.LastName = "Smith";
            user.Email = "john@test.com";
            user.Password = "password";
            user.IsAdmin = true;
            var result = dbHelper.CreateUser(user);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}