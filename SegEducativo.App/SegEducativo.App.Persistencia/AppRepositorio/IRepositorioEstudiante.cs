using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioEstudiante
{
    
    IEnumerable<Estudiante> GetAllEstudiante();
    Estudiante AddEstudiante (Estudiante Estudiante);
    Estudiante UpdateEstudiante (Estudiante Estudiante);
    void DeleteEstudiante (int IdEstudiante);
    Estudiante GetEstudiante (int IdEstudiante);    
    
}
}
