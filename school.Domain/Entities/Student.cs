public class Student : User
{
    public string FullName { get; set; } = string.Empty;
    public string Grade { get; set; } = string.Empty;
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;

    public Student(int id, string username, string password, string email, string fullName, string grade)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
        FullName = fullName;
        Grade = grade;
        EnrollmentDate = DateTime.Now;
        Role = UserRole.Student; 
    }
}