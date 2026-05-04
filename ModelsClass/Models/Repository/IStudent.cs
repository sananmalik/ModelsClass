using ModelsClass.Models;
namespace ModelsClass.Models.Repository
{
    public interface IStudent
    {
        List<ModelClass> GetStudents();
        ModelClass GetStudentById(int id);
    }
}
