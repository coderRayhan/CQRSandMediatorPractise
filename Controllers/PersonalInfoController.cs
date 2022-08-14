using MediatR;
using MediatrAndCQRSDemo.Context;
using MediatrAndCQRSDemo.Entities;
using MediatrAndCQRSDemo.Models;
using MediatrAndCQRSDemo.PersonalInfos.Commands.CreatePersonalInfo;
using MediatrAndCQRSDemo.PersonalInfos.Queries.PersonalInfoListQuery;
using MediatrAndCQRSDemo.PersonalInfos.Queries.PersonalInfoSingleQuery;
using MediatrAndCQRSDemo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediatrAndCQRSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfoController : ControllerBase
    {
        private  IMediator _mediator;
        private readonly IApplicationDbContext context;

        //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public IService Service { get; }

        public PersonalInfoController(IApplicationDbContext context, IService service, IMediator mediator)
        {
            _mediator = mediator;
            
            this.context = context;
            Service = service;
        }
        [HttpGet]
        public async Task<List<PersonalInfo>> Get()
        {
            return await _mediator.Send(new GetPersonalInfoListQuery());
        }

        [HttpGet("{id}")]
        public async Task<PersonalInfo> GetSingle(int id)
        {
            return await _mediator.Send(new PersonalInfoSingleQuery() { Id = id});
        }
        [HttpPost]
        public void CreatePersonalInfo(PersonalInfo personalInfo)
        {
            _mediator.Send(new CreatePersonalInfoCommand(personalInfo));
        }
    }
}
