namespace Modelo.ProductoModelo
{
    public class CategoriaProductos
    {
        private string _nombre;
        private int _idCategoria;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }

        public CategoriaProductos() { }

        public CategoriaProductos(int id, string nombre)
        {
            IdCategoria = id;
            Nombre = nombre;
        }
    }
}
