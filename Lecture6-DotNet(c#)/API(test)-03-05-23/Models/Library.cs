using System;
using Microsoft.EntityFrameworkCore;
using API_test__03_05_23.Models;
using API_test__03_05_23.Controllers;
using System.ComponentModel.DataAnnotations;

namespace API_test__03_05_23.Models
{
    public class Library
    {
        [Key] public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublishers { get; set; }
        public string PublishedYear { get; set; }
        public int BookPrice { get; set; }

    }
}
