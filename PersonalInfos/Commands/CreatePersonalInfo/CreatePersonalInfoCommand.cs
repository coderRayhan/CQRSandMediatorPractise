using MediatR;
using MediatrAndCQRSDemo.Entities;

namespace MediatrAndCQRSDemo.PersonalInfos.Commands.CreatePersonalInfo
{
    //public class CreatePersonalInfoCommand : IRequest<int>
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public DateTime DoB { get; set; }
    //    public string Phone { get; set; }
    //    public string Email { get; set; }
    //    public bool IsNew { get; set; }
    //}

    public record CreatePersonalInfoCommand(PersonalInfo PersonalInfo) : IRequest<int>;
}
