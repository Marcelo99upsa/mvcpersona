using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apiPersona.Models
{
    public enum SexType         //Lista para suponer que "0" es Femenino
    {
        Femenino=0,
        Masculino=1,
    }
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(250,ErrorMessage ="Ingresar Nombre entre a 5 a 250 Caracteres",MinimumLength =5)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime BirthDate { get; set; }
        public SexType Sex { get; set; }
    }
}