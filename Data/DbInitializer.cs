using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VladimirUniversity.Models;

namespace VladimirUniversity.Data
{
    public class DbInitializer
    {
        public static void Inicializa(UniversidadeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
            {
                return;
            }

            var alunos = new Aluno[]
            {
                new Aluno{Nome = "João", Sobrenome = "Carneiro", DataDeMatricula=DateTime.Parse("2017-12-01")},
                new Aluno{Nome = "Maria", Sobrenome= "Princesa", DataDeMatricula=DateTime.Parse("2016-11-02")},
                new Aluno{Nome = "Joaquina", Sobrenome= "Silva", DataDeMatricula=DateTime.Parse("2014-10-03")},
                new Aluno{Nome = "Fulano", Sobrenome= "Souza", DataDeMatricula=DateTime.Parse("2016-09-22")},
                new Aluno{Nome = "Fredinilson", Sobrenome= "Bosco", DataDeMatricula=DateTime.Parse("2015-04-16")},
                new Aluno{Nome = "Vladimir", Sobrenome= "Vasconcelos", DataDeMatricula=DateTime.Parse("2017-12-25")}
            };

            foreach (Aluno aluno in alunos)
            {
                context.Alunos.Add(aluno);
            }
            context.SaveChanges();

            var cursos = new Curso[]
            {
                new Curso{CursoId=1120, Nome = "Matemática", Creditos=7},
                new Curso{CursoId=1221, Nome = "Física", Creditos=4},
                new Curso{CursoId=1322, Nome = "Cálculo", Creditos=8},
                new Curso{CursoId=1423, Nome = "História do Mundo", Creditos= 2},
                new Curso{CursoId=1524, Nome = "Álgebra Linear", Creditos= 5},
            };

            foreach (Curso curso in cursos)
            {
                context.Cursos.Add(curso);
            }
            context.SaveChanges();

            var matriculas = new Matricula[]
            {
                new Matricula{AlunoId=1, CursoId = 1120, Mencao = Mencao.SS},
                new Matricula{AlunoId=1, CursoId = 1423, Mencao = Mencao.MM},
                new Matricula{AlunoId=2, CursoId=1221, Mencao = Mencao.MS},
                new Matricula{AlunoId=2, CursoId = 1524, Mencao = Mencao.MI},
                new Matricula{AlunoId=2, CursoId = 1322, Mencao = Mencao.MS},
                new Matricula{AlunoId=3, CursoId = 1120, Mencao = Mencao.SS},
                new Matricula{AlunoId=3, CursoId = 1423, Mencao = Mencao.MM},
                new Matricula{AlunoId=4, CursoId=1221, Mencao = Mencao.MS},
                new Matricula{AlunoId=4, CursoId = 1423, Mencao = Mencao.II},
                new Matricula{AlunoId=4, CursoId = 1322, Mencao = Mencao.MS},
                new Matricula{AlunoId=5, CursoId = 1120, Mencao = Mencao.SS},
                new Matricula{AlunoId=5, CursoId = 1423, Mencao = Mencao.MM},
                new Matricula{AlunoId=6, CursoId=1120, Mencao = Mencao.MI},
                new Matricula{AlunoId=6, CursoId = 1221, Mencao = Mencao.SS},
                new Matricula{AlunoId=6, CursoId = 1322, Mencao = Mencao.MS},
            };

            foreach (Matricula matricula in matriculas)
            {
                context.Matriculas.Add(matricula);
            }
            context.SaveChanges();
        }
    }
}