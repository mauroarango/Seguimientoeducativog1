using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

public class RepositorioAcudiente : IRepositorioAcudiente

{
    private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioAcudiente(AppContext appContext)
        {
            this.appContext = appContext;
        }

        Acudiente IRepositorioAcudiente.AddAcudiente(Acudiente acudiente)
        {
        var acudientenuevo = _appContext.Acudiente.Add(acudiente);
        _appContext.SaveChanges();
        return acudientenuevo.Entity;
        }

        void IRepositorioAcudiente.DeleteAcudiente(int IdAcudiente)
        {
          var acudientencontrado=_appContext.Acudiente.FirstOrDefault(a =>a.Id==IdAcudiente);
         if (acudientencontrado==null)
         return;  _appContext.Acudiente.Remove(acudientencontrado);
         _appContext.SaveChanges();
        }

        IEnumerable<Acudiente> IRepositorioAcudiente.GetAllAcudiente()
        {
            return _appContext.Acudiente;
        }

        Acudiente IRepositorioAcudiente.GetAcudiente(int IdAcudiente)
        {
            var acudientencontrado=_appContext.Acudiente.FirstOrDefault(a =>a.Id==IdAcudiente);
           return acudientencontrado;
        }

        Acudiente IRepositorioAcudiente.UpdateAcudiente(Acudiente acudiente)
        {
             var acudientencontrado=_appContext.Acudiente.FirstOrDefault(a =>a.Id==acudiente.Id);
         if (acudientencontrado==null)
           {
            acudientencontrado.Nombre=acudiente.Nombre;
            acudientencontrado.Apellidos=acudiente.Apellidos;
            acudientencontrado.Parentesco=acudiente.Parentesco;
            acudientencontrado.Direccion=acudiente.Direccion;
            acudientencontrado.Ciudad=acudiente.Ciudad;
            acudientencontrado.Correo=acudiente.Correo;
            acudientencontrado.Celular=acudiente.Celular;
            acudientencontrado.Genero=acudiente.Genero;
                        
            _appContext.SaveChanges();
           }
           return acudientencontrado;
        }
    }
}