using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVCWithEFCF2.Models
{
    
   
    public class Customer
    {
      
        [Column(TypeName ="Money")]
        public decimal? Balance { get; set; }


        [Index] 
        [Required] 
        [MaxLength(50)]

        public string CustomerName { get; set; }
        
        [StringLength(1000)]

        [Column(TypeName = "Varchar")]

        public string Address { get; set; }
        public string CAddress { get; set; }
        [Key]
        public int Custid { get; set; }


        public int Sid { get; set; }

        [ForeignKey("Sid")]
        public Supplier Supplier { get; set; }


    }
}