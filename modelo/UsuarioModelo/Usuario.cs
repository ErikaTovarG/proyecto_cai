namespace Modelo.Usuario
{
    public class Usuario
    {
        #region Variables publicas
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaBaja { get; set; }
        public string usuario { get; set; }
        public int host { get; set; }
        public int dni { get; set; }
        public string contrasenia { get; set; }
        #endregion


        #region Contructores
        public Usuario()
        {

        }

        public Usuario(Guid id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento,
            //DateTime fechaAlta, DateTime fechaBaja, 
            string usuario, int host, int dni, string contrasenia
            )
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.host = host;
            fechaAlta = DateTime.Now;
            this.dni = dni;
            this.usuario = usuario;
            this.fechaNacimiento = fechaNacimiento;
            this.contrasenia = contrasenia;
        }

        #endregion

        public Usuario(string nombre)
        {
            this.nombre =nombre;   
        }

    }
}