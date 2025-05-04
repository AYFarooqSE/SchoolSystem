namespace SchoolSystem.Models
{
    public class TeachersModel
    {
        
        public int ID { get; set; }
        public string? TeacherID { get; set; }
        public string? Name { get; set; }
        public DateTime DOB { get; set; }
        public string? ImageUrl { get; set; }
        public string[]? Hobbies { get; set; }
        public string? Subjects { get; set; }
        public DateTime HireDate { get; set; }
    }
}
