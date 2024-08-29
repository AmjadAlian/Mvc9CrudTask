using System.ComponentModel.DataAnnotations;

namespace Mvc9CrudTask.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DataType("varchar")]
        [MaxLength(30)]
        public string Name { get; set; } = null!;
        public int Age { get; set; }
    }
}
