using AutoMapper;
using digitalAgency.Application.Dtos.Comments;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Comments.Queries.GetCommentById
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, CommentVm>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public GetCommentByIdQueryHandler(IMapper mapper, ICommentRepository repository)
        {
            _mapper = mapper;
            _commentRepository = repository;
        }

        public async Task<CommentVm> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var comment = await _commentRepository.GetByIdAsync(request.Id,false, cancellationToken);
            if (comment is null)
                return null!;
            return _mapper.Map<CommentVm>(comment); 

        }
    }
}
