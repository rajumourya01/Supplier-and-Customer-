using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MVCWithEFCF2.Models
{
    
    public class Supplier
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Sid { get; set; }

        [Required]
        [Column("Sname", TypeName = "Varchar")]
        [MaxLength(100,ErrorMessage ="Length Exedid")]
        [MinLength(1,ErrorMessage ="Enter at lest one char")]
        public string SName { get; set; }

        public ICollection<Customer> customers { get; set; }


    }
}