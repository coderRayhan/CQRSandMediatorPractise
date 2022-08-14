using MediatrAndCQRSDemo.Entities;

namespace MediatrAndCQRSDemo.Models
{
    public class PersonalInfoListVM
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsNew { get; set; }
    }
}
