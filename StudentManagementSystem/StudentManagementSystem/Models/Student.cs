namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }
        public string Email {  get; set; }
        public string PhoneNumber { get; set; }
        public string Gender {  get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public int CourseId { get; set; }
        public Course Course  { get; set; }
    }
}
