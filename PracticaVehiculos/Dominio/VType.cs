using System.Collections.Generic;

namespace PracticaVehiculos.Dominio
{
    public class VType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<VehicleD> Vehicles { get; set; }
    }
}
