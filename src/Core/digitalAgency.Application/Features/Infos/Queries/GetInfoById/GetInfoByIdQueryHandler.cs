using AutoMapper;
using digitalAgency.Application.Dtos.Infos;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Infos.Queries.GetInfoById
{
    public class GetInfoByIdQueryHandler : IRequestHandler<GetInfoByIdQuery, InfoVm>
    {
        private readonly IInfoRepository _infoRepository;
        private readonly IMapper _mapper;

        public GetInfoByIdQueryHandler(IInfoRepository infoRepository, IMapper mapper)
        {
            _infoRepository = infoRepository;
            _mapper = mapper;
        }

        public async Task<InfoVm> Handle(GetInfoByIdQuery request, CancellationToken cancellationToken)
        {
            var info = await _infoRepository.GetByIdAsync(request.Id,false,cancellationToken);
            if (info is null)
                return null!;
            return _mapper.Map<InfoVm>(info);   
        }
    }
}
