using EjemploCrud.Modelo;
using Microsoft.EntityFrameworkCore;

namespace EjemploCrud.Servicios
{
    public class ArticulosServicioDB : IArticulosServicio
    {

        ArticulosContext Db;
        public ArticulosServicioDB(ArticulosContext articulosContext)
        {
            Db = articulosContext;
        }


        public async Task<bool> Actualizar(Articulo dato)
        {
            var respuesta = await Db.Articulos.Where(X => X.Id.Equals(dato.Id)).FirstOrDefaultAsync();
            if (respuesta != null) return false;
            respuesta.Nombre = dato.Nombre;
            respuesta.Precio = dato.Precio;
            respuesta.FechaCompra = dato.FechaCompra;
            Db.Articulos.Update(respuesta);
            await Db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Agregar(Articulo dato)
        {
            var respuesta = await Db.Articulos.Where(X => X.Id.Equals(dato.Id)).FirstOrDefaultAsync();
            if (respuesta != null) return false;

            Db.Articulos.Add(dato);
            await Db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(string Id)
        {
            var respuesta = await Db.Articulos.Where(X => X.Id.Equals(Id)).FirstOrDefaultAsync();
            if (respuesta == null) return false;
            Db.Articulos.Remove(respuesta);
            await Db.SaveChangesAsync();
            return true;

        }

        public async Task<Articulo> Leer(string Id)
        {
            var respuesta = await Db.Articulos.Where(X => X.Id.Equals(Id)).FirstOrDefaultAsync();
            return respuesta;
        }

        public async Task<List<Articulo>> Listar()
        {

            var respuesta = await Db.Articulos.ToListAsync();
            return respuesta;
        }
    }
}
