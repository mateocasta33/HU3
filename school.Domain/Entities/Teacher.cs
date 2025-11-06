namespace school.Domain.Entities
{
    public class Teacher : User
    {
        public string TeacherName { get; set; }
        public string Specialty { get; set; }

        public Teacher(int id, string username, string password, string email, string teacherName, string specialty)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            TeacherName = teacherName;
            Specialty = specialty;
            Role = UserRole.Teacher;
        }
    }
}