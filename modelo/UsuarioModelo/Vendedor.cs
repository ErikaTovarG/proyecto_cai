using Modelo.Switch;

namespace Modelo.UsuarioModelo
{
    public class Vendedor : UsuarioModelo
    {

        #region Constructor 
        public Vendedor(Guid id, string nombre, string apellido, string direccion, string telefono, string email, string contrasenia, string usuario, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, int host, int dni, Estado estado)
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
            Estado = estado;
        }
        #endregion

        //public override string ToString()
        //{
        //    return $"ID: {Id}, " +
        //           $"Nombre: {Nombre}, " +
        //           $"Apellido: {Apellido}, " +
        //           $"Dirección: {Direccion}, " +
        //           $"Teléfono: {Telefono}, " +
        //           $"Email: {Email}, " +
        //           $"Contraseña: {Contrasenia}, " +
        //           $"Usuario: {Usuario}, " +
        //           $"Fecha de Alta: {FechaAlta}, " +
        //           $"Fecha de Nacimiento: {FechaNacimiento}, " +
        //           $"Fecha de Baja: {FechaBaja}, " +
        //           $"Host Seleccionado: {Host}, " +
        //           $"Salida DNI: {Dni}";
        //}

    }
}

