using Microsoft.AspNet.Identity;
using RecipeBox.Models;
using RecipeBox.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GrandmasRecipeBox.Controllers
{
    public class CommentController : ApiController
    {
        private CommentService CreateCommentService()
        {
            var Id = Guid.Parse(User.Identity.GetUserId());
            var commentService = new CommentService(Id);
            return commentService;
        }
        /// <summary>
        /// Get a Comment
        /// </summary>
        /// <returns>Returns a Comment</returns>
        public IHttpActionResult Get()
        {
            CommentService commentService = CreateCommentService();
            var comments = commentService.GetComment();
            return Ok(comments);
        }
        /// <summary>
        /// Create a Comment on a Recipe
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Comment Created</returns>
        public IHttpActionResult Post(CommentCreate comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(comment))
                return InternalServerError();

            return Ok();
        }
        /// <summary>
        /// Get Comment by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It's going to return the requested comments</returns>
        public IHttpActionResult Get(int id)
        {
            CommentService commentService = CreateCommentService();
            var comments = commentService.GetCommentById(id);
            return Ok(comments);
        }

        ///// <summary>
        ///// Get Comment by Recipe Id
        ///// </summary>
        ///// <param name="RecipeId"></param>
        ///// <returns>It's going to return the comments associated with a Recipe</returns>

        /// <summary>
        /// Get Comment by Recipe Id
        /// </summary>
        /// <param name="RecipeId"></param>
        /// <returns>It's going to return the comments associated with a Recipe</returns>

        //public IHttpActionResult GetRecipeComments(int RecipeId)
        //{
        //    CommentService commentService = CreateCommentService();
        //    var comments = commentService.GetCommentsByRecipeId(RecipeId);
        //    return Ok(comments);
        //}
        /// <summary>
        /// Edit a Comment
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Edit a Comment</returns>
        public IHttpActionResult Put(CommentEdit comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.UpdateComment(comment))
                return InternalServerError();

            return Ok();
        }
        /// <summary>
        /// Delete a Comment by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Deleted Comment</returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateCommentService();

            if (!service.DeleteComment(id))
                return InternalServerError();

            return Ok();
        }
    }
}
