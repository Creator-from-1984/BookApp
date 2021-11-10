using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Book
    { 
        private int _id;
        private string _title;
        private string _author; 
        private int _year; 
        public Book() { } 
        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        } 
        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public int Year { get => _year; set => _year = value; } 
    }
}
