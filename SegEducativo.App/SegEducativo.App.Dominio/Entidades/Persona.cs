namespace SegEducativo.App.Dominio


{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Apellidos{ get; set; }
        public string Direccion{ get; set; }
        public string Ciudad{ get; set; }
        public string Correo{ get; set; }
        public string Celular{ get; set; }

        public Genero Genero { set; get; }
    }
}
