using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

    public class RepositorioMateria : IRepositorioMateria

    {
        private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
        private AppContext appContext;

        public RepositorioMateria(AppContext appContext)
        {
            this.appContext = appContext;
        }

        Materia IRepositorioMateria.AddMateria(Materia materia)
        {
            var materianueva = _appContext.Materias.Add(materia);
            _appContext.SaveChanges();
            return materianueva.Entity;
        }

        void IRepositorioMateria.DeleteMateria(int Idmateria)
        {
            var materiaencontrada = _appContext.Materias.FirstOrDefault(m => m.Id == Idmateria);
            if (materiaencontrada == null)
                return;
            _appContext.Materias.Remove(materiaencontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Materia> IRepositorioMateria.GetAllMateria()
        {
            return _appContext.Materias;
        }

        Materia IRepositorioMateria.GetMateria(int Idmateria)
        {
            var materiaencontrada = _appContext.Materias.FirstOrDefault(m => m.Id == Idmateria);
            return materiaencontrada;
        }

        Materia IRepositorioMateria.UpdateMateria(Materia materia)
        {
            var materiaencontrada = _appContext.Materias.FirstOrDefault(m => m.Id == materia.Id);
            if (materiaencontrada != null)
            {
            materiaencontrada.Nombre=materiaencontrada.Nombre;
            materiaencontrada.Id=materiaencontrada.Id;
            _appContext.SaveChanges();
            }
                    
                    return materia;            
        }
    }
}
