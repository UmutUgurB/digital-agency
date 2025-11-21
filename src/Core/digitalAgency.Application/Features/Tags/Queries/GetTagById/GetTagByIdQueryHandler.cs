using AutoMapper;
using digitalAgency.Application.Dtos.Tags;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Tags.Queries.GetTagById
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, TagVm>
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public GetTagByIdQueryHandler(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<TagVm> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByIdAsync(request.Id, false, cancellationToken);
            return _mapper.Map<TagVm>(tag);
        }
    }
}

