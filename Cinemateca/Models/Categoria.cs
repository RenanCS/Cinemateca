using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinemateca.Models
{
    public class Categoria
    {
        [Key]    
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string NOME { get; set; }

        public virtual  ICollection<Filme> Filmes { get; set; }

    }


}