using Api.Models;
using APIdata;
using APIdata.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Controllers
{
    public class BlogController : Controller
    {
        private IApiDbContext _dbContext;
        
        public BlogController(IApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("api/blog/{id}")]
        public Blogs GetBlogs([FromRoute] int id)
        {
            Blogs blogs = new Blogs();
            blogs = _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefault();
            return blogs;
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
        [Route("api/blog")]
        public bool UpdateBlog([FromBody] UpdateBlog updateBlog)
        {
            if(UpdateBlog != null)
            {
                using(var context = new ApiDbContext())
            {

                    List<Blogs> blogs = new List<Blogs>();
                    blogs = _dbContext.Blogs.ToList();
                    Blogs blog = blogs.Where(bl => bl.Id == updateBlog.Id).FirstOrDefault();
                    blog.title = updateBlog.title;
                    blog.description = updateBlog.description;
                    context.SaveChangesAsync();
                }
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
