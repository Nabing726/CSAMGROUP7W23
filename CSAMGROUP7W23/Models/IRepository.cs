namespace CSAMGROUP7W23.Models
{
    public interface IRepository
    {
        IEnumerable<Student> Students { get; }

        Student this[string name] { get; }

        void AddStudent(Student student);

        void DeleteStudent(Student student);
    }
}
