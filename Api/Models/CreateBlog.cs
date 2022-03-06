namespace Api.Models
{
    public class CreateBlog
    {
        public string title { get; set; }
        public string description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
