namespace Modelo.UsuarioModelo
{
    public class UsuarioModelo
    {
        #region Variables Privadas
        private Guid _id;
        private string _nombre, _apellido, _direccion, _telefono, _email, _contrasenia, _usuario;
        private DateTime _fechaAlta, _fechaNacimiento, _fechaBaja;
        private int _host, _dni;

        #endregion

        #region Variables Publicas
        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public int Host { get => _host; set => _host = value; }
        public int Dni { get => _dni; set => _dni = value; }
        #endregion

        #region Contructores 
        public UsuarioModelo()
        {

        }
        public UsuarioModelo(Guid id, string nombre, string apellido, string direccion, string telefono, string email, string contrasenia, string usuario, DateTime fechaAlta, DateTime fechaNacimiento, DateTime fechaBaja, int host, int dni)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Contrasenia = contrasenia;
            Usuario = usuario;
            FechaAlta = fechaAlta;
            FechaNacimiento = fechaNacimiento;
            FechaBaja = fechaBaja;
            Host = host;
            Dni = dni;
        }
        #endregion

        public override string ToString()
        {
            return string.Format($"");
        }


        public static void CrearUsuarios()
        {
            RegistrarUsuario();
        }

        static List<UsuarioModelo> listaUsuarios = new List<UsuarioModelo>();
        private static void RegistrarUsuario()
        {
            Guid id = Guid.NewGuid(); //Se genera un id nuevo para el usuario.
            string nombre = "Juana";
            string apellido = "Juana";
            string direccion = "Juana";
            string telefono = "Juana";
            string email = "Juana";
            string contrasenia = "Juana";
            string usuario = "Juana";
            DateTime fechaAlta = DateTime.Now;
            DateTime fechaNacimiento = DateTime.Parse("2023/02/01");
            DateTime? fechaBaja = null;

            UsuarioModelo nu = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja ?? DateTime.MinValue, 1, 95852369);
            UsuarioModelo nu1 = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja ?? DateTime.MinValue, 1, 95852369);
            UsuarioModelo nu2 = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja ?? DateTime.MinValue, 1, 95852369);
            UsuarioModelo nu3 = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja ?? DateTime.MinValue, 1, 95852369);

            listaUsuarios.Add(nu);
            listaUsuarios.Add(nu2);
            listaUsuarios.Add(nu1);
            listaUsuarios.Add(nu3);

            Console.WriteLine("la lista tiene " + listaUsuarios.Count);
        }




        //Esta validacion debe ir en la capa de logica de negocio
        public bool validarNombre( string nombre, string apellido, string nombreUsuario )
        {
            nombre.ToLower();
            apellido.ToLower();
            nombreUsuario.ToLower();

            
            Console.WriteLine(nombreUsuario.Length);
            
            if(nombreUsuario.Length >= 8 && nombreUsuario.Length <= 15 )
            {
                if(!nombreUsuario.Contains(nombre) && !nombreUsuario.Contains(apellido))
                {
                    Console.WriteLine("Nombre de usuario correcto");
                    return true;
                }
                else
                {
                    Console.WriteLine("El nombre o el apellido no pueden estar contenidos en el nombre de usuario");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("El nombre de usuario debe tener entre 8 y 15 caracteres");
                return false;
            }
        }

    }
}