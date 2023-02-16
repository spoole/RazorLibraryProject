namespace RazorLibraryProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string AuthorLast { get; set; }
        public string AuthorFirst { get; set; }
        public string? Description { get; set; }
        public bool isAvailable { get; set; }
    }
}
