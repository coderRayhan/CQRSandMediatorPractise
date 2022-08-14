using MediatR;
using MediatrAndCQRSDemo.PersonalInfos.Commands.CreatePersonalInfo;
using MediatrAndCQRSDemo.Repositories;

namespace MediatrAndCQRSDemo.PersonalInfos.Handlers
{
    public class CreatePersonalInfoCommandHandler : IRequestHandler<CreatePersonalInfoCommand, int>
    {
        private readonly IService service;

        public CreatePersonalInfoCommandHandler(IService service)
        {
            this.service = service;
        }
        public Task<int> Handle(CreatePersonalInfoCommand request, CancellationToken cancellationToken)
        {
            service.CreateAsync(request.PersonalInfo);
            return Task.FromResult( request.PersonalInfo.Id);
        }
    }
}
