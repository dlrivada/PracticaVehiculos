using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PracticaVehiculos.Dominio;

namespace PracticaVehiculos.Contrato
{
    public interface IVTypeRepository
    {
        List<VType> GetVTypes();
        VType GetVTypeById(int id);
        void SaveVType(VType vType);
    }
}
