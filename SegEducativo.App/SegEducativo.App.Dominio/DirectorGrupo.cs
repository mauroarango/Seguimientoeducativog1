namespace SegEducativo.App.Dominio
{
    public class DirectorGrupo : Persona
    {

        public string Especialidad { get; set; }
        public Grupo Grupo { get; set; }
    }
}