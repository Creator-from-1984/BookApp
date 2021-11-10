using Newtonsoft.Json;
using System;
using System.Collections.Generic; 
using System.IO; 

namespace BookApp
{
    class ListOfBooks
    {
        List<Book> _books ;
        int indexator = 1;
        public ListOfBooks()
        {
            _books = new List<Book>();
            InitBooks();
        }
        public void InitBooks()
        {
            _books.Add(new Book(indexator++, "The Pilgrim’s Progress", "John Bunyan", 1678));
            _books.Add(new Book(indexator++, "Robinson Crusoe", "Daniel Defoe", 1719));
            _books.Add(new Book(indexator++, "Gulliver’s Travels", "Jonathan Swift", 1726));
            _books.Add(new Book(indexator++, "Clarissa", "Samuel Richardson", 1748));
            _books.Add(new Book(indexator++, "Tom Jones", "Henry Fielding", 1749));
            _books.Add(new Book(indexator++, "Emma", " Jane Austen", 1816));
            _books.Add(new Book(indexator++, "Frankenstein", "Mary Shelley", 1818));
            _books.Add(new Book(indexator++, "Nightmare Abbey", "Thomas Love Peacock", 1818));
            //https://www.theguardian.com/books/2015/aug/17/the-100-best-novels-written-in-english-the-full-list 
        }
        public void Show()
        {
            Console.WriteLine($"{ "Id",-4} {"Title",-30}{"Author",-23}{ "Year"}");
             
            foreach (var item in _books)
            { 
                Console.WriteLine($"{item.Id,-4} {item.Title,-30}{item.Author,-23}{ item.Year}");
            }
        } 
        public void Show(int index)
        {
            Console.WriteLine($"{ "Id",-4} {"Title",-30}{"Author",-23}{ "Year"}");
             
            foreach (var item in _books)
            {
                if (item.Id==index)
                {
                    Console.WriteLine($"{item.Id,-4} {item.Title,-30}{item.Author,-23}{ item.Year}"); 
                } 
            }
        } 
        public void Add(string a,string b, int c)
        { 
            _books.Add(new Book(indexator++, a, b, c)); 
        }
        public void Editing(string a, string b, int c,int index)
        {
            _books.RemoveAt(index);
            _books.Insert(index, new Book(indexator++, a, b, c));
            ChangeIndex();
        }
        public void Del(int index)
        {
            _books.RemoveAt(index);
            ChangeIndex();
        }
        public void ChangeIndex()
        {
            indexator = 1;
            foreach (var item in _books)
            {
                item.Id = indexator++;
            } 
        }
        public void Find(string a)
        { 
            foreach (var item in _books)
            {
                if (item.Id.ToString()==a||item.Author == a|| item.Title == a|| item.Year.ToString() == a)
                {
                    Console.WriteLine($"{item.Id,-4} {item.Title,-30}{item.Author,-23}{ item.Year}");
                } 
            } 
        }
        public void InFile(string str) 
        {
            string str1 = str + ".json";
            string json = JsonConvert.SerializeObject(_books, Formatting.Indented);
            File.WriteAllText(str1, json); 
        }
        public void FromFile(string str)
        {
            string str1 = str + ".json";
            if (File.Exists(str1))
            {
                string json1 = File.ReadAllText(str1);
                List<Book> tmp = JsonConvert.DeserializeObject<List<Book>>(json1);
                foreach (var book in tmp)
                {
                     _books.Add(new Book(book.Id, book.Title, book.Author, book.Year));
                    //Console.WriteLine($"{book.Id,-4} {book.Title,-30}{book.Author,-23}{ book.Year}");
                }
                ChangeIndex();
            }
            else
            {
                Console.WriteLine("File does not exist");
            } 
        } 
    }
}
