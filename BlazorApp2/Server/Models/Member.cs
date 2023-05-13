namespace BlazorApp2.Server.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Faculty { get; set; }
        public string Major { get; set; }
        public string ImagePath { get; set; }
        public Member( string firstName, string lastName, string role, string faculty, string major, string imagePath)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Faculty = faculty;
            Major = major;
            ImagePath = imagePath;
        }
        public Member() { }
    }
}
