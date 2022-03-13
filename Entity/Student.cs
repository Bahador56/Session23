using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entity
{
    public class Student 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public  DateTime Birthdate { get; set; }

        [MaxLength(10)]
        public  string StudentNumber { get; set; }
    }
}
