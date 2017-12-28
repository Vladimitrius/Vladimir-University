namespace VladimirUniversity.Models
{
    public enum Mencao
    {

        SS, MS, MM, MI, II
    }

    public class Matricula
    {

        public int MatriculaId { get; set; }
        public int CursoId { get; set; }
        public int AlunoId { get; set; }
        public Mencao? Mencao { get; set; }

        public Curso Curso { get; set; }
        public Aluno Aluno { get; set; }
    }
}