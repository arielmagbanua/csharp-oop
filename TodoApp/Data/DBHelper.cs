using Microsoft.Data.Sqlite;

namespace TodoApp.Data
{
    public sealed class DBHelper
    {
        private static DBHelper? _instance = null;

        private SqliteConnection? _connection = null;

        private DBHelper() {
            _connection = new SqliteConnection("Data Source=todo_database.db");

            // open the connection
            _connection.Open();

            // create users command
            var createUsersCommand = _connection.CreateCommand();
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

            // create todos command
            var createTodoCommand = _connection.CreateCommand();
            createTodoCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS 'todos' (
                    'id' INTEGER UNIQUE,
                    'user_id' INTEGER NOT NULL,
                    'title' TEXT NOT NULL,
                    'description' TEXT,
                    'status' INTEGER,
                    'created_at' TEXT,
                    PRIMARY KEY ('id' AUTOINCREMENT)
                );
            ";

            // execute the create users table
            createUsersCommand.ExecuteNonQuery();

            // execute the create todos table
            createTodoCommand.ExecuteNonQuery();
        }

        public static DBHelper Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBHelper();
                }

                return _instance;
            }
        }

        public bool CreateUser(User user)
        {
            var createUserCommand = _connection?.CreateCommand();

            int isAdmin = user.IsAdmin ? 1 : 0;

            string insertSQL = $@"
                INSERT INTO users (first_name, last_name, email, password, is_admin)
                VALUES ('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Password}', '{isAdmin}')";

            createUserCommand.CommandText = insertSQL;

            return createUserCommand.ExecuteNonQuery() > 0;
        }
    }
}
