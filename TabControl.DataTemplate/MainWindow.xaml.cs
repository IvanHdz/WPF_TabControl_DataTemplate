using System.Collections.Generic;
using System.Windows;

namespace TabControl.DataTemplate
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            List<Propiedades> lp = new List<Propiedades>
            {
                new Propiedades { Nombre = "Manzana", Peso = 100, Precio = 5.1 },
                new Propiedades { Nombre = "Platano", Peso = 50, Precio = 4.4 },
                new Propiedades { Nombre = "Aguacate", Peso = 10, Precio = 5.2 }
            };

            List<Propiedades> lp1 = new List<Propiedades>
            {
                new Propiedades { Nombre = "Televisión", Peso = 150, Precio = 500.0 },
                new Propiedades { Nombre = "Estereo", Peso = 200, Precio = 432.12 },
                new Propiedades { Nombre = "Proyectos", Peso = 15, Precio = 321.56 }
            };

            List<Propiedades> lp2 = new List<Propiedades>
            {
                new Propiedades { Nombre = "Escoba", Peso = 100, Precio = 56.11 },
                new Propiedades { Nombre = "Detergente", Peso = 50, Precio = 73.21 },
                new Propiedades { Nombre = "Suavitel", Peso = 10, Precio = 98.21 }
            };

            List<Propiedades> lp3 = new List<Propiedades>
            {
                new Propiedades { Nombre = "Inyecciones", Peso = 100, Precio = 56.11 },
                new Propiedades { Nombre = "Alcohol", Peso = 50, Precio = 73.21 },
                new Propiedades { Nombre = "Paracetamol", Peso = 10, Precio = 98.21 }
            };

            Area = new List<Area>();
            Area.Add(new Area { Id = 1, Description = "Alimentos", Subcategoria = lp });
            Area.Add(new Area { Id = 2, Description = "Electronica", Subcategoria = lp1 });
            Area.Add(new Area { Id = 3, Description = "Limpieza", Subcategoria = lp2 });
            Area.Add(new Area { Id = 4, Description = "Farmacia", Subcategoria = lp3 });
        }

        public List<Area> Area { get; set; }
    }
}