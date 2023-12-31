﻿
using Modelo.Switch;

namespace Modelo.UsuarioModelo

{
    public abstract class UsuarioModelo
    {
        #region Variables Privadas
        private Guid _id;
        private string _nombre, _apellido, _direccion, _telefono, _email, _contrasenia, _usuario;
        private object _estado;
        private DateTime _fechaAlta, _fechaNacimiento;
        private int _host, _dni, _contador;


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
        public DateTime? FechaBaja { get; set; }
        public int Host { get => _host; set => _host = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public int Contador { get => _contador; set => _contador = value; }
        public Estado Estado { get; set; }
	
    #endregion

    #region Contructores 
    public UsuarioModelo()
        {

        }
        public UsuarioModelo(Guid id, string nombre, string apellido, string direccion, string telefono, string email, string contrasenia, string usuario, DateTime fechaAlta, DateTime fechaNacimiento, DateTime fechaBaja, int host, int dni, int contador, Estado estado)
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
            Contador = contador;
            Estado = estado;
        }
        #endregion

        public string ToString()
        {
            return $"Nombre: {Nombre} \nApellido: {Apellido} \nDireccion: {Direccion} \nUsuario: {Usuario} \nHost: {Host} \nFecha Nacimiento: " +
                $"{FechaNacimiento} \nFecha Alta: {FechaAlta} \nDni: {Dni} \nEmail: {Email} \nTelefono: {Telefono}";
        }

    }
}