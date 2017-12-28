using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VladimirUniversity.Models
{

    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeMatricula { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}