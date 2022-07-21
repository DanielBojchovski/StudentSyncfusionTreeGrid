namespace StudentSyncfusionTreeGrid.Models
{
    public class Student
    {
        public Student() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public List<Class> Classes { get; set; }


        public static List<Student> GetStudentData()
        {
            List<Student> StudentCollection = new List<Student>();
            
            Class Csharp = new Class
            {
                ClassId = 1,
                Name = "C#",
                Tuition = 10000
            };

            Class Python = new Class
            {
                ClassId = 2,
                Name = "Python",
                Tuition = 9000
            };

            Class Javascript = new Class
            {
                ClassId = 3,
                Name = "Javascript",
                Tuition = 8000
            };

            Student Record1 = new Student()
            {
                Id = 1,
                Name = "Daniel",
                DOB = new DateTime(1992, 09, 18),
                Classes = new List<Class> { Csharp, Python }
            };

            Student Record2 = new Student()
            {
                Id = 2,
                Name = "Ilin",
                DOB = new DateTime(2020, 08, 04),
                Classes = new List<Class> { Csharp, Javascript }
            };

            Student Record3 = new Student()
            {
                Id = 3,
                Name = "Ivona",
                DOB = new DateTime(1989, 01, 26),
                Classes = new List<Class> { Python, Javascript }
            };

            Student Record4 = new Student()
            {
                Id = 4,
                Name = "Bojana",
                DOB = new DateTime(2002, 11, 11),
                Classes = new List<Class> { Python, Javascript, Csharp }
            };

            StudentCollection.Add(Record1);
            StudentCollection.Add(Record2);
            StudentCollection.Add(Record3);
            StudentCollection.Add(Record4);

            return StudentCollection;
        }

    }
}
