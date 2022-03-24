using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommentSystem.Model
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public String CommentText { get; set; }
        public String UserName { get; set; }
        public int ParentID { get; set; }

        [ForeignKey("ParentID")]
        public virtual ICollection<Comment> reply { get; set; }
    }
}
