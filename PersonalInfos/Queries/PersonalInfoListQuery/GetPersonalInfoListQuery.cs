
using MediatR;
using MediatrAndCQRSDemo.Entities;
using MediatrAndCQRSDemo.Models;

namespace MediatrAndCQRSDemo.PersonalInfos.Queries.PersonalInfoListQuery
{
    public class GetPersonalInfoListQuery : IRequest<List<PersonalInfo>>
    {
        
    }
}
