using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaVehiculos.Contrato;
using PracticaVehiculos.Dominio;

namespace EFSQLServerRepository
{
    public class VTypeRepository : BaseRepository<Type>, IVTypeRepository
    {
        public List<VType> GetVTypes()
        {
            AutoMapper.Mapper.CreateMap<Type, VType>();
            return
                new List<VType>(ObtenerTodos().AsEnumerable().Select(AutoMapper.Mapper.Map<VType>)).ToList();
        }

        public VType GetVTypeById(int id)
        {
            Type vType = ObtenerPorId(id);

            AutoMapper.Mapper.CreateMap<Type, VType>();
            return AutoMapper.Mapper.Map<VType>(vType);
        }

        public void SaveVType(VType vType)
        {
            AutoMapper.Mapper.CreateMap<VType, Type>();
            var miVType = AutoMapper.Mapper.Map<Type>(vType);

            Insertar(miVType);
        }
    }
}
