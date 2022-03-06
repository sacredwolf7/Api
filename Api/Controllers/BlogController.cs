using Api.Models;
using APIdata.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        [Route("api/blog/{id}")]
        public int GetBlogs([FromRoute] int id)
        {
            if(id != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        [HttpGet]
        [Route("api/blogs")]
        public Blogs GetBlogModel()
        {
            Blogs blogs = new Blogs();
            blogs.Id = 1;
            blogs.title = "title";
            blogs.description = "this is description";
            blogs.CreatedDate = DateTime.Now;

            return blogs;
        }
        [HttpPost]
        [Route("api/blog/post")]
        public bool createBlog([FromBody] CreateBlog createBlog)
        {
            return true;
        }
        [HttpPut]
        [Route("api/blog/{id}")]
        public Blogs updateBlog([FromRoute] int id)
        {
            List<Blogs> blogs = new List<Blogs>();
            Blogs blog = blogs.Where(bl => bl.Id == id).FirstOrDefault();
            return blog;
        }
    }
}
