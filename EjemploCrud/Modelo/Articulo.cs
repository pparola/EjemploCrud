namespace EjemploCrud.Modelo
{
    public class Articulo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public  double Precio { get; set; }
        public DateTime FechaCompra { get; set; }

        public Articulo()
        {
            Id = Guid.NewGuid().ToString();
            Nombre = string.Empty;
            Precio = 0;
            FechaCompra = DateTime.Now;
        }
    }
}
