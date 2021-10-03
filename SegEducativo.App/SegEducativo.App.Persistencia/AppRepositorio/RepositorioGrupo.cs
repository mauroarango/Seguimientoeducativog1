using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

public class RepositorioGrupo : IRepositorioGrupo

{
    private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioGrupo(AppContext appContext)
        {
            this.appContext = appContext;
        }

        Grupo IRepositorioGrupo.AddGrupo(Grupo grupo)
        {
            var gruponuevo = _appContext.Grupo.Add(grupo);
        _appContext.SaveChanges();
        return gruponuevo.Entity;
        }

        void IRepositorioGrupo.DeleteGrupo(int Idgrupo)
        {
      var grupoencontrado=_appContext.Grupo.FirstOrDefault(g =>g.Id==Idgrupo);
       if (grupoencontrado==null)
       return;
       _appContext.Grupo.Remove(grupoencontrado);
       _appContext.SaveChanges();
        }

        IEnumerable<Grupo> IRepositorioGrupo.GetAllGrupo()
        {
        return _appContext.Grupo;
        }

        Grupo IRepositorioGrupo.GetGrupo(int Idgrupo)
        {
            var grupoencontrado=_appContext.Grupo.FirstOrDefault(g =>g.Id==Idgrupo);
        return grupoencontrado;
        }

        Grupo IRepositorioGrupo.UpdateGrupo(Grupo grupo)
        {
            var grupoencontrado=_appContext.Grupo.FirstOrDefault(g =>g.Id==grupo.Id);
     if (grupoencontrado!=null)
     {
      grupoencontrado.Nombre=grupoencontrado.Nombre;
      grupoencontrado.Id=grupoencontrado.Id;
      
      _appContext.SaveChanges();

     }

       return grupoencontrado;
        }
}
}