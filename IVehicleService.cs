using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace VehicleService
{
    [ServiceContract()]
   public interface IVehicleService
    {
        [OperationContract()]
        [WebGet(UriTemplate="vehicles")]
        List<Vehicle> GetVehicleList();

        [OperationContract()]
        [WebGet(UriTemplate = "vehicles/?Id={Id}")]
        Vehicle GetVehicleById(int Id);

        [OperationContract()]
        [WebInvoke(UriTemplate = "vehicles",Method ="POST")]
        void AddVehicle(Vehicle av);

        [OperationContract()]
        [WebInvoke(UriTemplate = "vehicles", Method = "PUT")]
        void UpdateVehicle(Vehicle uv);

        [OperationContract()]
        [WebInvoke(UriTemplate = "vehicles/?Id={Id}", Method = "DELETE")]
        void DelteVehicle(int Id);


    }
}
