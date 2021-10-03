using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioDirectorGrupo
{
    
    IEnumerable<DirectorGrupo> GetAllDirector();
    DirectorGrupo AddDirector (DirectorGrupo director);
    DirectorGrupo UpdateDirector (DirectorGrupo director);
    void DeleteDirector (int Iddirector);
    DirectorGrupo GetDirector (int Iddirector);    
    
}
}