using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioAcudiente
{
    
    IEnumerable<Acudiente> GetAllAcudiente();
    Acudiente AddAcudiente (Acudiente acudiente);
    Acudiente UpdateAcudiente (Acudiente acudiente);
    void DeleteAcudiente (int IdAcudiente);
    Acudiente GetAcudiente (int IdAcudiente);    
    
}
}