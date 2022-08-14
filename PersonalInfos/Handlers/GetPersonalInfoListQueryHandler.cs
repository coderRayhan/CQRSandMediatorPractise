using AutoMapper;
using MediatR;
using MediatrAndCQRSDemo.Context;
using MediatrAndCQRSDemo.Entities;
using MediatrAndCQRSDemo.PersonalInfos.Queries.PersonalInfoListQuery;
using MediatrAndCQRSDemo.Repositories;

namespace MediatrAndCQRSDemo.PersonalInfos.Handlers
{
    public class GetPersonalInfoListQueryHandler : IRequestHandler<GetPersonalInfoListQuery, List<PersonalInfo>>
    {
        private readonly IMapper _mapper;
        private readonly IService _context;

        public GetPersonalInfoListQueryHandler(IMapper mapper, IService context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<List<PersonalInfo>> Handle(GetPersonalInfoListQuery request, CancellationToken cancellationToken)
        {
          
            return _context.GetAllAsync();
        }
    }
}
