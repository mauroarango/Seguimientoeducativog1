
namespace SegEducativo.App.Dominio

{
    public class Profesor : Persona
    {
       
        public Grupo Grupo { get; set; }

        public Materia Materia { get; set; }

        public Estudiante Estudiante { get; set; }

        
    }
}

