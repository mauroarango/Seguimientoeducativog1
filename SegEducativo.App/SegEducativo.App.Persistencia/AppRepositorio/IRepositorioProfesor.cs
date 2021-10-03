using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioProfesor
{
    
    IEnumerable<Profesor> GetAllProfesor();
    Profesor AddProfesor (Profesor profesor);
    Profesor UpdateProfesor (Profesor profesor);
    void DeleteProfesor (int Idprofesor);
    Profesor GetProfesor (int IdProfesor);    
    
}
}
