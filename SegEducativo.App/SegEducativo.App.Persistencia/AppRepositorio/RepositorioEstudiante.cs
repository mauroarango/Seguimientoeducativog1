using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

public class RepositorioEstudiante : IRepositorioEstudiante

{
    private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioEstudiante(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public Estudiante AddEstudiante(Estudiante Estudiante)
    {
        var estudiantenuevo = _appContext.Estudiantes.Add(Estudiante);
        _appContext.SaveChanges();
        return estudiantenuevo.Entity;
    }

        public void DeleteEstudiante(int IdEstudiante)
    {
       var estudiantencontrado=_appContext.Estudiantes.FirstOrDefault(e =>e.Id==IdEstudiante);
       if (estudiantencontrado==null)
       return;
       _appContext.Estudiantes.Remove(estudiantencontrado);
       _appContext.SaveChanges();
    }

        public IEnumerable<Estudiante> GetAllEstudiante()
    {
        return _appContext.Estudiantes;
    }

        public Estudiante GetEstudiante(int IdEstudiante)
    {
        var estudiantencontrado=_appContext.Estudiantes.FirstOrDefault(e =>e.Id==IdEstudiante);
        return estudiantencontrado;
    }

        public Estudiante UpdateEstudiante(Estudiante Estudiante)
    {
     var estudiantencontrado=_appContext.Estudiantes.FirstOrDefault(e =>e.Id==Estudiante.Id);
     if (estudiantencontrado!=null)
    
     {
    
          estudiantencontrado.Nombre=Estudiante.Nombre;
          estudiantencontrado.Apellidos=Estudiante.Apellidos;
          estudiantencontrado.Direccion=Estudiante.Direccion;
          estudiantencontrado.Ciudad=Estudiante.Ciudad;
          estudiantencontrado.Correo=Estudiante.Correo;
          estudiantencontrado.Celular=Estudiante.Celular;
          estudiantencontrado.Genero=Estudiante.Genero;
          estudiantencontrado.Grupo=Estudiante.Grupo;
          estudiantencontrado.Materia=Estudiante.Materia;
          estudiantencontrado.FechaNacimiento=Estudiante.FechaNacimiento;
          estudiantencontrado.Acudiente=Estudiante.Acudiente;
          estudiantencontrado.DirectorGrupo=Estudiante.DirectorGrupo;

         _appContext.SaveChanges();
     }
      return estudiantencontrado;
     }
     
     }

    }




