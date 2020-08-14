using System.Collections.Generic;

namespace TabControl.DataTemplate
{
    public class Area
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Propiedades> Subcategoria { get; set; }
    }
}