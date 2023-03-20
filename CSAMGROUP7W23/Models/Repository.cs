namespace CSAMGROUP7W23.Models
{
    public class Repository : IRepository
    {
        private Dictionary<string, Student> students;
        public Repository()
        {
            students = new Dictionary<string, Student>();
            new List<Student> {

                new Student { ID = 841087, Name = "Nabin Gurung" },
                new Student { ID = 845788, Name = "Alson Basnet"},
                new Student { ID = 841895, Name = "Bablu Yadav" },
                new Student { ID = 846275, Name = "Bijay Koirala"},
                new Student { ID = 843695, Name = "Emre Uras"}

            }.ForEach(p => AddStudent(p));
        }

        public IEnumerable<Student> Students => students.Values;
        public Student this[string name] => students[name];
        public void AddStudent(Student student) => students[student.Name] = student;
        public void DeleteStudent(Student student) => students.Remove(student.Name);
    }
}
