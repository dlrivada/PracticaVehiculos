using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaVehiculos.Contrato;
using PracticaVehiculos.Dominio;

namespace EFSQLServerRepository
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public List<PracticaVehiculos.Dominio.VehicleD> GetVehicles()
        {
            AutoMapper.Mapper.CreateMap<Vehicle, PracticaVehiculos.Dominio.VehicleD>();
            return
                new List<PracticaVehiculos.Dominio.VehicleD>(ObtenerTodos().AsEnumerable().Select(AutoMapper.Mapper.Map<PracticaVehiculos.Dominio.VehicleD>)).ToList();
        }

        public PracticaVehiculos.Dominio.VehicleD GetVehicleById(int id)
        {
            Vehicle vehicle = ObtenerPorId(id);

            AutoMapper.Mapper.CreateMap<Vehicle, PracticaVehiculos.Dominio.VehicleD>();
            return AutoMapper.Mapper.Map<PracticaVehiculos.Dominio.VehicleD>(vehicle);
        }

        public List<PracticaVehiculos.Dominio.VehicleD> GetVehiclesByBrand(string brand)
        {
            IQueryable<Vehicle> vehicles = Filtrar(o => o.Brand == brand);
            AutoMapper.Mapper.CreateMap<Vehicle, PracticaVehiculos.Dominio.VehicleD>();
            return new List<PracticaVehiculos.Dominio.VehicleD>(vehicles.AsEnumerable().Select(AutoMapper.Mapper.Map<PracticaVehiculos.Dominio.VehicleD>)).ToList();  
        }

        public List<PracticaVehiculos.Dominio.VehicleD> GetVehiclesByRegistration(string registration)
        {
            IQueryable<Vehicle> vehicles = Filtrar(o => o.Registration == registration);
            AutoMapper.Mapper.CreateMap<Vehicle, PracticaVehiculos.Dominio.VehicleD>();
            return new List<PracticaVehiculos.Dominio.VehicleD>(vehicles.AsEnumerable().Select(AutoMapper.Mapper.Map<PracticaVehiculos.Dominio.VehicleD>)).ToList();
        }

        public void SaveVehicle(PracticaVehiculos.Dominio.VehicleD vehicleD)
        {
            AutoMapper.Mapper.CreateMap<PracticaVehiculos.Dominio.VehicleD, Vehicle>();
            Vehicle mivehicle = AutoMapper.Mapper.Map<Vehicle>(vehicleD);

            Insertar(mivehicle);
        }
    }
}
