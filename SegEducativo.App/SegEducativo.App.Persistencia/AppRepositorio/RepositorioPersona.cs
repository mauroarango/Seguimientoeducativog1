using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

    public class RepositorioPersona : IRepositorioPersona

    {
      private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioPersona(AppContext appContext)
        {
            this.appContext = appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personanueva = _appContext.Persona.Add(persona);
        _appContext.SaveChanges();
        return personanueva.Entity;
        }

        void IRepositorioPersona.DeletePersona(int IdPersona)
        {
            var personencontrada=_appContext.Persona.FirstOrDefault(p =>p.Id==IdPersona);
       if (personencontrada==null)
       return;
       _appContext.Persona.Remove(personencontrada);
       _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Persona;
        }

        Persona IRepositorioPersona.GetPersona(int IdPersona)
        {
            var personencontrada=_appContext.Persona.FirstOrDefault(p =>p.Id==IdPersona);
        return personencontrada;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personencontrada=_appContext.Persona.FirstOrDefault(p =>p.Id==persona.Id);
            if (personencontrada==null)
         {
             personencontrada.Nombre=persona.Nombre;
             personencontrada.Apellidos=persona.Apellidos;
             personencontrada.Direccion=persona.Direccion;
             personencontrada.Ciudad=persona.Ciudad;
             personencontrada.Correo=persona.Correo;
             personencontrada.Ciudad=persona.Ciudad;
             personencontrada.Celular=persona.Celular;
             personencontrada.Genero=persona.Genero;              
        
             _appContext.SaveChanges();
          }
               return personencontrada;
        }
    }
}
