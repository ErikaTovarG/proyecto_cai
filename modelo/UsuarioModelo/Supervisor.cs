namespace Modelo.UsuarioModelo
{
<<<<<<< HEAD
    public Supervisor(Guid id, string nombre, string apellido, string direccion, string telefono, string email, string contrasenia, string usuario, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, int host, int dni)
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
=======
    public class Supervisor : UsuarioModelo
    {
        #region Constructor 
        public Supervisor(Guid id, string nombre, string apellido, string direccion, string telefono, string email, string contrasenia, string usuario, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, int host, int dni)
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
>>>>>>> 1bbf51ee6cd76152d8d57547ec0c30f0d1382b33
    }

}
