using System.ComponentModel.DataAnnotations;

namespace BaiKiemTraKy072025.Models
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        public string FullName { get; set; }
        public int  Age { get; set; }
    }
}