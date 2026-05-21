namespace Entidad
{
    public class UsuarioEntity
    {
        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int CodigoRol { get; set; }
        public bool Estado { get; set; }
    }
}
