using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;


namespace Cinemateca.Models
{
    public class Filme
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NOME { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.MultilineText)]
        public string SINOPSE { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ANO { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DIRETOR { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int IDCATEGORIA { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Avaliacao> Avaliacaos { get; set; }



    }
}