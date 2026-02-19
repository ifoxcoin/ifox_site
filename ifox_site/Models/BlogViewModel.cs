namespace ifox_site.Models
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Date { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string HtmlFile { get; set; }

    }
}
