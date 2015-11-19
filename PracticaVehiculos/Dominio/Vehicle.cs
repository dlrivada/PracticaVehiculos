namespace PracticaVehiculos.Dominio
{
    public class VehicleD
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public VType Type { get; set; }
    }
}
