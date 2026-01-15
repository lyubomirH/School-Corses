using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First_LAB.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(2000)]
        public string PostContent { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<PostAnswer> PostAnswers { get; set; }
    }
}
