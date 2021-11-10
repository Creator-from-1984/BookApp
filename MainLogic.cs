using System; 

namespace BookApp
{
    class MainLogic
    {
        public void  StartApp()
        {
            ListOfBooks books = new ListOfBooks();
            int b = -1;
            while (b != 0)
            {
                Console.WriteLine("Enter your chooce");
                Console.WriteLine();
                Console.WriteLine("Add book press 1");
                Console.WriteLine("Delete book press 2");
                Console.WriteLine("Edit book press 3");
                Console.WriteLine("Find a book press 4");
                Console.WriteLine("Write to file press 5");
                Console.WriteLine("Read from file press 6");
                Console.WriteLine("Show the list of books press 7");
                Console.WriteLine("Show book by index press 8");
                Console.WriteLine("To exit the program, press 0"); 
                string buf1 = Console.ReadLine();
                b = int.Parse(buf1);
                switch (b)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter title");
                            string a = Console.ReadLine();
                            Console.WriteLine("Enter author");
                            string f = Console.ReadLine();
                            Console.WriteLine("Enter year");
                            int c = int.Parse(Console.ReadLine());
                            books.Add(a, f, c);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter index of book for delete");
                            int c = int.Parse(Console.ReadLine()) - 1;
                            books.Del(c);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter index of book for edite");
                            int index = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine("Enter new Title");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter new Author");
                            string author = Console.ReadLine();
                            Console.WriteLine("Enter new Year");
                            int year = int.Parse(Console.ReadLine());  
                            books.Editing(title,author,year,index);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter author or title or year to find book");
                            string a=Console.ReadLine();
                            books.Find(a);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter a filename without an extension");
                            Console.WriteLine("Enter filename for writing"); 
                            string str = Console.ReadLine();
                            books.InFile(str);  
                            break;
                        }
                    case 6:
                        { 
                            Console.WriteLine("Enter a filename without an extension");
                            Console.WriteLine("Enter filename for reading (existing file -> Books)");
                            string str= Console.ReadLine();
                            books.FromFile(str); 
                            break;
                        }
                    case 7:
                        {
                            books.Show();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Enter the book index");
                            int index = int.Parse(Console.ReadLine());
                            books.Show(index);
                            break;
                        }
                    case 0:
                        {
                            b = 0;
                            break;
                        }
                    default:
                        break;
                }
            } 
        }
    }
}
