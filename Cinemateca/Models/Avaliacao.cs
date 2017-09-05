using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinemateca.Models
{
    public class Avaliacao
    {
        [Key]
        public int ID { get; set; }

        public int IDFILME { get; set; }

        [DataType(DataType.MultilineText)]
        public string CRITICA { get; set; }

        public int NOTA { get; set; }
                                                         

        public virtual ICollection<Filme> Filmes { get; set; }

    }
}