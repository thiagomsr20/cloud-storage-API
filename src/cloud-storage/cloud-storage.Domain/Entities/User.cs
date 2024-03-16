﻿namespace cloud_storage.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public User()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
        }
    }
}