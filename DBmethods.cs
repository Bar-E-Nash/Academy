using System.Data;



namespace Academy 
{
    internal class DBmethods
    {
        public static List<string> StudentNames()
        {
            var students = new List<string>();

            DataTable studTable = GetStudenesTable();

            foreach (DataRow row in studTable.Rows)
            {
                students.Add(row["LastName"].ToString() + " " + row["FirstName"].ToString());
            }

            return students;

        }

        public static List<string> TeacherNames()
        {
            var teachers = new List<string>();

            DataTable studTable = GetTeachersTable();

            foreach (DataRow row in studTable.Rows)
            {
                teachers.Add(row["LastName"].ToString() + " " + row["FirstName"].ToString());
            }

            return teachers;
        }
        
        public static DataTable GetCoursesTable()
        {
            DataTable coursesTable = DBcontext.MakeQuery("SELECT * FROM Courses", []);
            return coursesTable;
        }
        public static DataTable GetStudenesTable()
        {
            DataTable StudenesTable = DBcontext.MakeQuery("SELECT * FROM Students", []);
            return StudenesTable;
        }
        public static DataTable GetTeachersTable()
        {
            DataTable TeachersTable = DBcontext.MakeQuery("SELECT * FROM Teachers", []);
            return TeachersTable;
        }

        public static void AddCourse(string name, string dateOpen, int courseFee, string days, string hours)
        {
            DBcontext.MakeQuery("INSERT INTO Courses(" +
                                "CourseName, DateOfOpen, CourseFee, DaysInWeek, HoursInDay)" +
                                "VALUES(" +
                                $"'{name}', '{dateOpen}',{courseFee},\r\n'{days}','{hours}')", []);
        }

        public static void AddTeacher(string firstName, string lastName, int hourFee)
        {
            DBcontext.MakeQuery("INSERT INTO Teachers(" +
                                "FirstName, LastName, HourlyRate)" +
                                "VALUES(" +
                                $"'{firstName}', '{lastName}',{hourFee}", []);
        }
    }

}
