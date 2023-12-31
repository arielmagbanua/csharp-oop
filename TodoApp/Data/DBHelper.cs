﻿using Microsoft.Data.Sqlite;

namespace TodoApp.Data
{
    public sealed class DBHelper
    {
        /// <summary>
        /// The singleton instance of this DBHelper class
        /// </summary>
        private static DBHelper? _instance = null;

        /// <summary>
        /// The sqlite connection object
        /// </summary>
        private SqliteConnection? _connection = null;

        /// <summary>
        /// The name of the database.
        /// </summary>
        public const string DB_NAME = "todo_database.db";

        private DBHelper() {
            _connection = new SqliteConnection("Data Source=" + DB_NAME);

            // open the connection
            _connection.Open();

            // create users command
            var createUsersCommand = _connection.CreateCommand();
            createUsersCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS 'users' (
                    'id' INTEGER UNIQUE,
                    'first_name' TEXT NOT NULL DEFAULT '',
                    'last_name' TEXT NOT NULL DEFAULT '',
                    'email' TEXT NOT NULL UNIQUE,
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

        /// <summary>
        /// Retrieve the instance of this DBHelper
        /// </summary>
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

        /// <summary>
        /// This method creates a new user.
        /// </summary>
        /// <param name="user">The tentative user object.</param>
        /// <returns>It return the newly created user</returns>
        public User? CreateUser(User user)
        {
            var createUserCommand = _connection?.CreateCommand();

            int isAdmin = user.IsAdmin ? 1 : 0;

            createUserCommand!.CommandText = $@"
                INSERT INTO users (first_name, last_name, email, password, is_admin)
                VALUES ('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Password}', '{isAdmin}')
            ";

            try
            {
                var result = createUserCommand.ExecuteNonQuery();

                if (result < 0)
                {
                    return null; // result is negative, therefore it failed to create the user
                }

                user.Id = GetUserID(user.Email);
            } 
            catch (Exception)
            {
                user.Id = GetUserID(user.Email);
            }

            
            return user;
        }

        public User? GetUserByEmail(string email)
        {
            var getUserCommand = _connection!.CreateCommand();
            getUserCommand.CommandText = @$"
                SELECT * FROM users WHERE email = '{email}'
            ";

            var reader = getUserCommand.ExecuteReader();

            if (reader.Read()) {
                var userId = reader.GetInt32(0);
                var firstName = reader.GetString(1);
                var lastName = reader.GetString(2);
                var userEmail = reader.GetString(3);
                var password = reader.GetString(4);
                var isAdmin = reader.GetInt32(5);

                var user = new User();
                user.Id = userId;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Email = userEmail;
                user.Password = password;
                user.IsAdmin = isAdmin == 1;
                return user;
            }

            return null;
        }

        /// <summary>
        /// This retrieve the id of the user using an email.
        /// </summary>
        /// <param name="email">The email of the user.</param>
        /// <returns>The id of the user.</returns>
        private int GetUserID(string email)
        {
            // retrieve the user
            var selectCommand = _connection?.CreateCommand();
            selectCommand!.CommandText = $@"SELECT id FROM users WHERE email='{email}'";
            var reader = selectCommand.ExecuteReader();

            if (!reader.Read())
            {
                return -1;
            }

            // read the user id
            int userId = reader.GetInt32(0);

            return userId;
        }

        /// <summary>
        /// This method creates a new todo for a certain user.
        /// </summary>
        /// <param name="todo">The todo object</param>
        /// <returns>Returns true if successful otherwise false if not.</returns>
        public bool CreateTodo(Todo todo)
        {
            var createTodoCommand = _connection?.CreateCommand();

            createTodoCommand!.CommandText = $@"
                INSERT INTO todos (user_id, title, description, status, created_at)
                VALUES ('{todo.UserId}', '{todo.Title}', '{todo.Description}', '{todo.Status}', '{todo.CreateAt}')
            ";

            return createTodoCommand.ExecuteNonQuery() > 0;
        }

        public List<Todo> GetTodos(int userId)
        {
            var todoList = new List<Todo>();

            var getTodosCommand = _connection?.CreateCommand();

            getTodosCommand!.CommandText = $@"
                SELECT * FROM todos WHERE user_id='{userId}'
            ";

            var reader = getTodosCommand.ExecuteReader();

            while (reader.Read()) {
                var todoId = reader.GetInt32(0);
                var title = reader.GetString(2);
                var description = reader.GetString(3);
                var status = reader.GetInt32(4);
                var createAt = reader.GetString(5);

                Todo todo = new Todo();
                todo.Id = todoId;
                todo.UserId = userId;
                todo.Title = title;
                todo.Description = description;
                todo.Status = status;
                todo.CreateAt = createAt;

                todoList.Add(todo);
            }

            return todoList;
        }
    }
}
