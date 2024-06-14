using NuGet.LibraryModel;

namespace WebApplication11.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public int LibraryID { get; set; } // Foreign key 
        public Library Library { get; set; }
    }
    public class Library
    {
        public int LibraryID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
