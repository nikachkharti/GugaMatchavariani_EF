using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GugaMatchavariani_EF.Entities
{
    public class Subject
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public double Score { get; set; }

        //MxM
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
