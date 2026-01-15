using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First_LAB.Data.Entities
{
    public class PostAnswer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(2000)]
        public string AnswerContent { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }
        
    }
}
