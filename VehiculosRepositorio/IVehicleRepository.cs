using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaVehiculos.Dominio;

namespace PracticaVehiculos.Contrato
{
    public interface IVehicleRepository
    {
        List<VehicleD> GetVehicles();
        VehicleD GetVehicleById(int id);
        List<VehicleD> GetVehiclesByBrand(string brand);
        List<VehicleD> GetVehiclesByRegistration(string registration);
        void SaveVehicle(VehicleD vehicleD);
    }
}
