using Moq;
using school.Application.Services;
using school.Domain.Entities;
using school.Infrastructure.Repositories;

namespace school.Test.Unit;

public class StudentServicesTest
{
    private readonly Mock<IRepository<Student>> _repository;
    private readonly StudentService _studentService;

    public StudentServicesTest(StudentService studentService, Mock<IRepository<Student>> repository)
    {
        _repository = new Mock<IRepository<Student>>();
        _studentService = new StudentService(_repository.Object);
    }

    [Fact]
    public async Task ReturnStudent_When_Create()
    {
        var student = new Student
        {
            FirstName = "Diego",
            LastName = "Zapata"
        };

        _repository
            .Setup(s => s.Create(student))
            .ReturnsAsync(student);

        var result = await _studentService.Create(student);

        Assert.NotNull(result);
        Assert.Equal("Diego", student.FirstName);
        Assert.Equal("Zapata", student.LastName);
    }

    [Fact]
    public async Task ReturnProfessor_When_Create()
    {
        var professor = new Student
        {
            FirstName = "Samuel",
            LastName = "Giraldo"
        };

        _repository.Setup(p => p.Create(professor))
            .ReturnsAsync(professor);
    }
}