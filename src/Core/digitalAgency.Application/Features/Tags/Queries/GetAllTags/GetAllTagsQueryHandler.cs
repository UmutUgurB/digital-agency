using AutoMapper;
using digitalAgency.Application.Dtos.Tags;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Tags.Queries.GetAllTags
{
    public class GetAllTagsQueryHandler : IRequestHandler<GetAllTagsQuery, IList<TagVm>>
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public GetAllTagsQueryHandler(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<IList<TagVm>> Handle(GetAllTagsQuery request, CancellationToken cancellationToken)
        {
            var tags = await _tagRepository.GetAllAsync(false, cancellationToken);
            return _mapper.Map<IList<TagVm>>(tags);
        }
    }
}

