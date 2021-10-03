using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

public class RepositorioDirectorGrupo : IRepositorioDirectorGrupo

{
    private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioDirectorGrupo(AppContext appContext)
        {
            this.appContext = appContext;
        }

        DirectorGrupo IRepositorioDirectorGrupo.AddDirector(DirectorGrupo director)
        {
            var directornuevo = _appContext.Director.Add(director);
        _appContext.SaveChanges();
        return directornuevo.Entity;
        }

        void IRepositorioDirectorGrupo.DeleteDirector(int Iddirector)
        {
            var directorencontrado=_appContext.Director.FirstOrDefault(d =>d.Id==Iddirector);
         if (directorencontrado==null)
         return;  _appContext.Director.Remove(directorencontrado);
         _appContext.SaveChanges();
        }

        IEnumerable<DirectorGrupo> IRepositorioDirectorGrupo.GetAllDirector()
        {
            return _appContext.Director;
        }

        DirectorGrupo IRepositorioDirectorGrupo.GetDirector(int Iddirector)
        {
             var directorencontrado=_appContext.Director.FirstOrDefault(d =>d.Id==Iddirector);
           return directorencontrado;
        }

        DirectorGrupo IRepositorioDirectorGrupo.UpdateDirector(DirectorGrupo director)
        {
             var directorencontrado=_appContext.Director.FirstOrDefault(d =>d.Id==director.Id);
         if (directorencontrado==null)
         {
             directorencontrado.Nombre=director.Nombre;
             directorencontrado.Apellidos=director.Apellidos;
             directorencontrado.Direccion=director.Direccion;
             directorencontrado.Correo=director.Correo;
             directorencontrado.Celular=director.Celular;
             directorencontrado.Ciudad=director.Ciudad;
             directorencontrado.Genero=director.Genero;
             directorencontrado.Especialidad=director.Especialidad;
             directorencontrado.Grupo=director.Grupo;     

             _appContext.SaveChanges();
         }
         return directorencontrado;
        }
    }
}