using CommentSystem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CommentsController(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet("GetComments")]
        public IActionResult GetComments()
        {
            var comments =  GetAll();
            return Ok(comments);
        }

        [HttpPost("AddComments")]
        public  IActionResult AddComments(CommmentDTO commment)
        {
            var _comments = new Comment()
            { 
                ParentID = commment.ParentID,
                CommentText = commment.CommentText,
                UserName = commment.UserName,
            };

            _context.comments.Add(_comments);
            _context.SaveChanges();
            return Ok();
        }
        private IQueryable GetAll()
        {
            return _context.comments.OrderBy(x=>x.ParentID);
        }
    }
}
