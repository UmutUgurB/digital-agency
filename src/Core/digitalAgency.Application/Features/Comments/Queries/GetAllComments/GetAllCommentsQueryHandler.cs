using AutoMapper;
using digitalAgency.Application.Dtos.Comments;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Comments.Queries.GetAllComments
{
    public class GetAllCommentsQueryHandler : IRequestHandler<GetAllCommentsQuery, IList<CommentVm>>
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public GetAllCommentsQueryHandler(ICommentRepository commentReposRepository, IMapper mapper)
        {
            _commentRepository = commentReposRepository;
            _mapper = mapper;
        }

        public async Task<IList<CommentVm>> Handle(GetAllCommentsQuery request, CancellationToken cancellationToken)
        {
            var comments = await _commentRepository.GetAllAsync(false, cancellationToken);
            return _mapper.Map<IList<CommentVm>>(comments); 
        }
    }
}
