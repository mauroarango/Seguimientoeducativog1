using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioPersona
{
    
    IEnumerable<Persona> GetAllPersona();
    Persona AddPersona (Persona persona);
    Persona UpdatePersona(Persona persona);
    void DeletePersona (int IdPersona);
    Persona GetPersona (int IdPersona);    
    
}
}
