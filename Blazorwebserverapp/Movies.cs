﻿using System.ComponentModel.DataAnnotations;

namespace Blazorwebserverapp
{
    public class Movies
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
