﻿namespace TodoApp
{
    public class Todo
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public string CreateAt { get; set; }
    }
}
