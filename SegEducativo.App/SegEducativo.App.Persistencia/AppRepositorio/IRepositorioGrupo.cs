using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioGrupo
{
    
    IEnumerable<Grupo> GetAllGrupo();
    Grupo AddGrupo (Grupo grupo);
    Grupo UpdateGrupo (Grupo grupo);
    void DeleteGrupo (int Idgrupo);
    Grupo GetGrupo (int Idgrupo);    
    
}
}