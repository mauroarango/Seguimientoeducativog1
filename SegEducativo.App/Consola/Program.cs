using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;
using SegEducativo.App.Persistencia;

namespace Consola
{
    class Program
    {
        private static IRepositorioEstudiante _repoEstudiante=new RepositorioEstudiante(new SegEducativo.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("prueba crud!");
            //AddEstudiante();
            buscarestudiante(1);
        }
        private static void AddEstudiante()
        {
            var Estudiante=new Estudiante
            {
              Nombre="luz",
              Apellidos="arias",
              Celular="1234",
              Genero=Genero.masculino,
              Direccion="calle sin fin",
              Ciudad="Bogota",
              Correo="luzp@",
              
        };
            _repoEstudiante.AddEstudiante(Estudiante);
        }
        private static void buscarestudiante(int IdEstudiante)
        {
          var Estudiante = _repoEstudiante.GetEstudiante(IdEstudiante);
        Console.WriteLine(Estudiante.Nombre+" "+Estudiante.Apellidos);

        }
    }
}
