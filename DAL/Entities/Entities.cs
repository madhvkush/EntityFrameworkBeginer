using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.DAL.Entities
{
   public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string RollNUmber { get; set; }
        public DateTime DOB { get; set; }
        
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }

    public class Course
    {
        public Course() // Many-many relation b/w course and book
        {
            Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }  // 1-Many b/w Student and Course
        public virtual ICollection<Book> Books { get; set; } //Many-many 

    }

    public class Book
    {
       public Book() // Many-many relation b/w course and book
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Course> Courses { get; set; } //Many-many 
    }

    public class HomeAdress
    {
        [ForeignKey("Student")]
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string State { get; set; }


        public Student Student { get; set; } // 1-1 Relation
    }
}
