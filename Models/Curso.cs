using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VladimirUniversity.Models
{
    public class Curso
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public int Creditos { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}