using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1.Cursos
{
    public class CursoTest
    {
    public class Curso
    {
        
        public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
        {
                if (string.IsNullOrEmpty(nome))
                    throw new ArgumentException();

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }
        public string Nome { get; set; }
        public double CargaHoraria { get;  set; }
        public string PublicoAlvo { get;  set; }
        public double Valor { get; set; }
    }

        public enum PublicoAlvo
        {
            Estudante,
            Universitario,
            Empregado,  
            Empreendedor
        }

        [Fact]
        public void DeveCriarCurso()
        {
            var cursoEsperado = new
            {
            Nome = "Informática básica",
            CargaHoraria = (double)80,
            PublicoAlvo = "Estudantes",
            Valor = (double)950 
        };
        
             var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

             cursoEsperado.ToExpectedObject().ShouldMatch(curso);

        }
        [Fact]
        public void NaoDeveCursoTerUmNomeVazio()
        {
            var cursoEsperado = new
            {
                Nome = "Informática básica",
                CargaHoraria = (double)80,
                PublicoAlvo = "Estudantes",
                Valor = (double)950
            };

            Assert.Throws<ArgumentException>(() => 
                new Curso(string.Empty, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor));
        }
        [Fact]

        public void NaoDeveCursoTerUmNomeNulo()
        {
            var cursoEsperado = new
            {
                Nome = "Informática básica",
                CargaHoraria = (double)80,
                PublicoAlvo = "Estudantes",
                Valor = (double)950
            };

            Assert.Throws<ArgumentException>(() =>
                new Curso(null, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor));
        }

    }

}
