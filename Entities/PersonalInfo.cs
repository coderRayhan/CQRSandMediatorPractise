namespace MediatrAndCQRSDemo.Entities
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsNew { get; set; }
        public ICollection<EducationalInfo> EducationalInfos { get; set; }
    }
}
