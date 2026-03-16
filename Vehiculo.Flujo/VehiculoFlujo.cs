using Vehiculo.Abstracciones.Interfaces.DA;
using Vehiculo.Abstracciones.Interfaces.Flujo;
using Vehiculo.Abstracciones.Modelos;

namespace Vehiculo.Flujo
{
    public class VehiculoFlujo : IVehiculoFlujo
    {
        private readonly IVehiculoDA _vehiculoDA;

        public VehiculoFlujo(IVehiculoDA vehiculoDA)
        {
            _vehiculoDA = vehiculoDA;
        }

        public Task<Guid> AgregarVehiculo(VehiculoRequest vehiculo)
        {
            return _vehiculoDA.AgregarVehiculo(vehiculo);
        }

        public Task<Guid> Editar(Guid Id, VehiculoRequest vehiculo)
        {
            return _vehiculoDA.Editar(Id, vehiculo);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _vehiculoDA.Eliminar(Id);
        }

        public Task<IEnumerable<VehiculoResponse>> ObtenerVehiculos()
        {
            return _vehiculoDA.ObtenerVehiculos();
        }

        public Task<VehiculoResponse> ObtenerVehiculo(Guid Id)
        {
            return _vehiculoDA.ObtenerVehiculo(Id);
        }
    }
}
