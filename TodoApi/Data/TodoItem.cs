﻿namespace TodoApi.Data
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public bool Done { get; set; }
    }
}
