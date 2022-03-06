namespace Api.Models
{
    public class UpdateBlog
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
