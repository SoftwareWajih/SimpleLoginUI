namespace SimpleLoginUI.Models
{
    public class StudentModel
    {
        [PrimaryKey, AutoIncrement]
        public int StudentID { get; set; }

        [Required]
        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Email { get; set; }


        [Ignore]
        public string FullName => $"{FirstName} {LastName}";
    }
}
