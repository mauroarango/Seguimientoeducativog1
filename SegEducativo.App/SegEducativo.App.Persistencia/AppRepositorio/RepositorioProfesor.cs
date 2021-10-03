using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

    public class RepositorioProfesor : IRepositorioProfesor

    {
      private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioProfesor(AppContext appContext)
        {
            this.appContext = appContext;
        }

        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
           var profesornuevo = _appContext.Profesores.Add(profesor);
        _appContext.SaveChanges();
        return profesornuevo.Entity;
        }

        void IRepositorioProfesor.DeleteProfesor(int Idprofesor)
        {
          var profesorencontrado=_appContext.Profesores.FirstOrDefault(pr =>pr.Id==IdProfesor);
       if (profesorencontrado==null)
       return;
       _appContext.Profesores.Remove(profesorencontrado);
       _appContext.SaveChanges();
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesor()
        {
           return _appContext.Profesores;
        }

        Profesor IRepositorioProfesor.GetProfesor(int IdProfesor)
        {
            var profesorencontrado=_appContext.Profesores.FirstOrDefault(pr =>pr.Id==IdProfesor);
        return profesorencontrado;
        }

        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            var profesorencontrado=_appContext.Profesores.FirstOrDefault(pr =>pr.Id==profesor.Id);
            if (profesorencontrado==null)
            {
             profesorencontrado.Nombre=persona.Nombre;
                
            }
        }
    }
}