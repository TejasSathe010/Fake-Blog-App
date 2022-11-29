using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheFakeBlog.API.Data;

namespace TheFakeBlog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly TheFakeBlogDbContext dbContext;

        public PostsController(TheFakeBlogDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await dbContext.Posts.ToListAsync();
            return Ok(posts);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            var posts = await dbContext.Posts.FirstOrDefaultAsync();
            if(posts != null)
            {
                return Ok(posts);
            }
            return NotFound(); 
        }

        [HttpPost]
        public async Task<IActionResult> AddPost()
        {

        }
        
    }
}
