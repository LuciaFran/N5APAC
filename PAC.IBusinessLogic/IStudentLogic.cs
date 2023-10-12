namespace PAC.IBusinessLogic;

using global::PAC.Domain;
using PAC.Domain;

public interface IStudentLogic
{
    IEnumerable<Student> GetStudents();
    Student GetStudentById(int id);
    void InsertStudents(Student? student);

}

