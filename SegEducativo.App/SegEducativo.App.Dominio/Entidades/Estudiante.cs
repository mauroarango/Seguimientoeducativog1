using System;

namespace SegEducativo.App.Dominio
{
    
    public class Estudiante : Persona
    {
    
    public Grupo Grupo { get; set; }
    public Materia Materia { get; set; }
    public DateTime FechaNacimiento { get; set; } 
    public Acudiente Acudiente { get; set; }
    public DirectorGrupo DirectorGrupo { get; set; }
    


}
}