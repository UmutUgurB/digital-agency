using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Dtos.Infos;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Infos.Queries.GetAllInfos
{
    public class GetAllInfosQueryHandler : IRequestHandler<GetAllInfosQuery, IList<InfoVm>>
    {
        private readonly IInfoRepository _infoRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetAllInfosQueryHandler(IInfoRepository infoRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _infoRepository = infoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<InfoVm>> Handle(GetAllInfosQuery request, CancellationToken cancellationToken)
        {
            var infos = await _infoRepository.GetAllAsync(false, cancellationToken);
            return _mapper.Map<IList<InfoVm>>(infos);   
        }
    }
}
