using EjemploCrud.Modelo;

namespace EjemploCrud.Servicios
{
    public interface IArticulosServicio
    {
        public Task<List<Articulo>> Listar();
        public Task<Articulo> Leer(string Id);
        public Task<bool> Actualizar(Articulo dato);
        public Task<bool> Eliminar(string Id);
        public Task<bool> Agregar(Articulo dato);
    }
}
