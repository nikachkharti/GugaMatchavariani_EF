using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GugaMatchavariani_EF.Entities
{
    public class StudentSubject
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }


        //[ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
