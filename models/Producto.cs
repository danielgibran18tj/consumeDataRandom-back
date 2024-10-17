using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace ConsumeAgrosotf.models
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string CreationAt { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }

        // Relación con Imagen
        public List<Imagen> images { get; set; }
    }

    [Table("Imagen")]
    public class Imagen
    {
        public int ImagenId { get; set; }
        public int ProductoId { get; set; }
        public string ImagenString { get; set; }

        [JsonIgnore]
        public Producto Producto { get; set; }
    }
}
