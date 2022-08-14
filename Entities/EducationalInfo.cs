namespace MediatrAndCQRSDemo.Entities
{
    public class EducationalInfo
    {
        public int Id { get; set; }
        public string HighestDegree { get; set; }
        public int PassingYear { get; set; }
        public decimal CGPA { get; set; }
        public string Institution { get; set; }
        public int PersonalInfoId { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
