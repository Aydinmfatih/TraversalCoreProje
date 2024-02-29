using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetDestinationById(id);
            return View(value);
        }
    }
}
