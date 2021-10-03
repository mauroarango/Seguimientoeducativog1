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
            throw new NotImplementedException();
        }

        void IRepositorioProfesor.DeleteProfesor(int Idprofesor)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesor()
        {
            throw new NotImplementedException();
        }

        Profesor IRepositorioProfesor.GetProfesor(int IdProfesor)
        {
            throw new NotImplementedException();
        }

        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            throw new NotImplementedException();
        }
    }
}