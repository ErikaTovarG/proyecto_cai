﻿using AccesoDatos.Utilidades;
using Newtonsoft.Json;
using Modelo.UsuarioModelo;
using System.Web;
using System.Collections.Generic;

namespace AccesoDatos
{
    public static class UsuarioDatos
    {

        public static List<UsuarioWebServices> Listarusuarios(Guid idUsuarioAdmin)
        {
            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + idUsuarioAdmin);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWebServices> listadousuarios = JsonConvert.DeserializeObject<List<UsuarioWebServices>>(contentstream);
                return listadousuarios;

            }
        }

        public static void CrearUsuario(UsuarioWebServicePost usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                //throw new Exception(response.StatusCode.ToString());
                Console.WriteLine(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine("Usuario agregado exitosamente.");
            }

        }

        public static void EliminarUsuario(UsuarioWebServiceDelete usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                //throw new Exception(response.StatusCode.ToString());
                Console.WriteLine(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine("Usuario agregado exitosamente.");
            }
        }
        public static string Login(Login login)
        {
            var jsonRequest = JsonConvert.SerializeObject(login);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                //throw new Exception(response.StatusCode.ToString());
                return null;
            }
            else
            {
                var reader = new StreamReader(response.Content.ReadAsStream());
                String respuesta = reader.ReadToEnd();
                return respuesta;
            }

        }

        public static string CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }

        public static void BorrarUsuario(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        public static void ReactivarUsuario(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
        }
        public static void InactivarUsuario(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
        }

    }
}