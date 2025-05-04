namespace SchoolSystem.Models.StudentModels
{
    public class StudentModel
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string Name { get; set; }
        public DateTime DOB {  get; set; }
        public string Image {  get; set; }
        public string StudentId {  get; set; }
        public Guid Hobbies { get; set; }
        public DateTime AddmissionDate { get; set; }
    }
}
