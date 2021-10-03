using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioMateria
{
    
    IEnumerable<Materia> GetAllMateria();
    Materia AddMateria (Materia materia);
    Materia UpdateMateria (Materia materia);
    void DeleteMateria (int Idmateria);
    Materia GetMateria (int Idmateria);    
    
}
}