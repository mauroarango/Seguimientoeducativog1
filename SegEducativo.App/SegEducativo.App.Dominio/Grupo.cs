namespace SegEducativo.App.Dominio
{
    public class Grupo
    {
        public string Codigo { set; get;}
        public Estudiante Estudiante { get; set; }
        public DirectorGrupo DirectorGrupo {get; set; }
        public Profesor profesor { get; set; }
    }
}