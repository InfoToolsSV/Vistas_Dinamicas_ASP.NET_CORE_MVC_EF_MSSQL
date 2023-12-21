using VistasDinamicas.Models;

namespace VistasDinamicas.ViewModels
{
    public class ProductosViewModel
    {
        public List<Producto> Productos { get; set; } = null!;
        public Producto? ProductoSeleccionado { get; set; }
    }
}