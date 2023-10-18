using AccesoDatos.Utilidades;
using Newtonsoft.Json;
using Modelo.UsuarioModelo;
using System.Web;

namespace AccesoDatos
{
    public static class UsuarioDatos
    {

        //public static list<usuariomodelo> listarusuarios()
        //{
        //    httpresponsemessage response = webhelper.get("usuario/traerusuariosactivos");

        //    if (!response.issuccessstatuscode)
        //    {
        //        throw new exception("verifique los datos ingresados");
        //    }
        //    else
        //    {
        //        var contentstream = response.content.readasstringasync().result;
        //        list<usuariomodelo> listadousuarios = jsonconvert.deserializeobject<list<usuariomodelo>>(contentstream);
        //        return listadousuarios;
        //    }
        //}
        public static List<UsuarioWebServices> ListarUsuarios(string id)
        {
            // Construye la URL con el parámetro en la cadena de consulta
            string url = $"Usuario/TraerUsuariosActivos?id={HttpUtility.UrlEncode(id)}";

            HttpResponseMessage response = WebHelper.Get(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWebServices> listadoUsuarios = JsonConvert.DeserializeObject<List<UsuarioWebServices>>(contentStream);
                return listadoUsuarios;
            }
        }

        public static void CrearUsuario(UsuarioModelo usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static string Login(Login login)
        {
            var jsonRequest = JsonConvert.SerializeObject(login);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
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
       

    }
}