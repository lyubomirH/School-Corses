using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First_LAB.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<PostAnswer> Answers { get; set; }
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
    }
}
