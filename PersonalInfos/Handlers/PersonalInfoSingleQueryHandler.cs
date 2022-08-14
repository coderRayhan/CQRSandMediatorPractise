using MediatR;
using MediatrAndCQRSDemo.Entities;
using MediatrAndCQRSDemo.PersonalInfos.Queries.PersonalInfoSingleQuery;
using MediatrAndCQRSDemo.Repositories;

namespace MediatrAndCQRSDemo.PersonalInfos.Handlers
{
    public class PersonalInfoSingleQueryHandler : IRequestHandler<PersonalInfoSingleQuery, PersonalInfo>
    {
        private readonly IService service;

        public PersonalInfoSingleQueryHandler(IService service)
        {
            this.service = service;
        }
        public async Task<PersonalInfo> Handle(PersonalInfoSingleQuery request, CancellationToken cancellationToken)
        {
            var result = await service.GetAsync(request.Id);
            return new PersonalInfo()
            {
                Id = result.Id,
                Name = result.Name,
                DoB = result.DoB,
                IsNew = result.IsNew,
                Email = result.Email,
                Phone = result.Phone
            };
        }
    }
}
