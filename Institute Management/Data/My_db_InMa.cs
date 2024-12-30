
using Institute_Management.Model;
using Microsoft.EntityFrameworkCore;

namespace Institute_Management.Data
{
    public class My_db_InMa : DbContext
    {
        public My_db_InMa(DbContextOptions<My_db_InMa> options) : base(options)
        {

        }
        public   DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Meterial> Meterials { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Registretion> registretions { get; set; }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<Certificate> certificates { get; set; }
        public DbSet<Geade> Geade { get; set; } = default!;


    }
}
