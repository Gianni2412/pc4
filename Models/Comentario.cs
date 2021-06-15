using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pc4.Models
{
    public class Comentario
    {

        public int Id { get; set; }

        [Required]
        public string texto { get; set; }

    
        public DateTime Fecha { get; set; }


        public ICollection<Fail> Fails { get; set; }















    }
}