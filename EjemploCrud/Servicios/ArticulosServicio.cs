using EjemploCrud.Modelo;

namespace EjemploCrud.Servicios
{
    
    public class ArticulosServicio: IArticulosServicio
    {

        private List<Articulo> _articulos = new List<Articulo>();

        public ArticulosServicio()
        {
            _articulos.Add(new Articulo() { Nombre = "Zapatilla", Precio = 10000, FechaCompra = new DateTime(2022, 5, 11) });
            _articulos.Add(new Articulo() { Nombre = "Medias", Precio = 2000, FechaCompra = new DateTime(2021, 6, 22) });

        }

        public async Task<Articulo> Leer(string Id)
        {
            await Task.Delay(1);
            var respuesta = _articulos.Where(X => X.Id.Equals(Id)).FirstOrDefault();
            return respuesta;
        }


        public async Task<bool> Agregar(Articulo dato)
        {
            await Task.Delay(1);
            var respuesta = _articulos.Where(X => X.Id.Equals(dato.Id)).FirstOrDefault();

            if (respuesta != null)
            {
                return false;
            }
            _articulos.Add(dato);
            return true;
        }


        public async Task<bool> Actualizar(Articulo dato)
        {
            await Task.Delay(1);
            var respuesta = _articulos.Where(X => X.Id.Equals(dato.Id)).FirstOrDefault();

            if (respuesta == null)
            {
                return false;
            }

            respuesta.Nombre = dato.Nombre;
            respuesta.Precio = dato.Precio;
            respuesta.FechaCompra = dato.FechaCompra;
            return true;
        }


        public async Task<bool> Eliminar(string Id)
        {
            await Task.Delay(1);
            var respuesta = _articulos.Where(X => X.Id.Equals(Id)).FirstOrDefault();
            if (respuesta == null)
            {
                return false;
            }
            _articulos.Remove(respuesta);
            return true;
        }



        public async Task<List<Articulo>> Listar()
        {
            await Task.Delay(1);

            var respuesta = _articulos;
            return respuesta;
        }
    }
}
