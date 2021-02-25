using RecipeBox.Data;
using RecipeBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Services
{
    public class CommentService
    {
        private readonly int _commentId;
        public CommentService(int commentId)
        {
            _commentId = commentId;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comments()
                {
                    CommentId = _commentId,
                    Text = model.Text,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CommentItem> GetComment()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    .Where(e => e.CommentId == _commentId)
                    .Select(
                        e =>
                        new CommentItem
                        {
                            CommentId = e.CommentId,
                            Text = e.Text,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        }
        public CommentDetail GetCommentById(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == commentId && e.RecipeId == _recipeId);
                return
                    new CommentDetail
                    {
                        CommentId = entity.CommentId,
                        Text = entity.Text,
                        CreatedUtc = entity.CreatedUtc
                    };
            }
        }
        public bool UpdateComment(CommentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == model.CommentId && e.RecipeId == _recipeId);

                entity.Text = model.Text;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;


            }
        }
    }
}
