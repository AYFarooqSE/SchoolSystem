namespace SchoolSystem.Models
{
    public class TeachersModel
    {
        
        public int ID { get; set; }
        public string? TeacherID { get; set; }
        public int Name { get; set; }
        public int DOB { get; set; }
        public int ImageUrl { get; set; }
        public string[]? Hobbies { get; set; }
        public int Subjects { get; set; }
        public DateTime HireDate { get; set; }
    }
}
