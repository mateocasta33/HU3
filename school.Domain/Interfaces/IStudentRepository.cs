using school.Domain.Entities;

namespace school.Domain.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student?> GetById(int id);
        Task Create(Student student);
        Task Update(Student student);
        Task Delete(int id);
    }
}