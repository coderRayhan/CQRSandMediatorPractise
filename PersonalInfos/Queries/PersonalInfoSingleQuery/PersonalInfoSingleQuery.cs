using MediatR;
using MediatrAndCQRSDemo.Entities;

namespace MediatrAndCQRSDemo.PersonalInfos.Queries.PersonalInfoSingleQuery
{
    public class PersonalInfoSingleQuery : IRequest<PersonalInfo>
    {
        public int Id { get; set; }
    }
}
