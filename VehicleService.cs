using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace VehicleService
{
    public class VehicleService : IVehicleService
    {
        public void AddVehicle(Vehicle av)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO VEHICLE(Id,Year,Make,Model) VALUES");
            sb.AppendFormat("({0},{1},'{2}','{3}')",
                av.Id, av.Year, av.Make, av.Model);
            (new DbHelper()).SqlExecute(sb.ToString());
    
        }

        public void DelteVehicle(int Id)
        {
            (new DbHelper()).SqlExecute("DELETE from Vehicle where Id="+Id);
        }

        public Vehicle GetVehicleById(int Id)
        {
            var dt = (new DbHelper()).GetResultSet("Select Id,Year,Make,Model from Vehicle where Id ="+Id);
            if (dt.Rows.Count > 0)
            {
                var dr = dt.Rows[0];
                return new Vehicle()
                {
                    Id = Int32.Parse(dr["Id"].ToString()),
                    Year = Int32.Parse(dr["Year"].ToString()),
                    Make = dr["Make"].ToString(),
                    Model = dr["Model"].ToString()
                };
            }
            return null;

        }

        public List<Vehicle> GetVehicleList()
        {
            var dt = (new DbHelper()).GetResultSet("Select Id,Year,Make,Model from Vehicle");
            var qVeh=from dr in dt.AsEnumerable()
                     select new Vehicle()
                        {
                         Id = Int32.Parse(dr["Id"].ToString()),
                         Year = Int32.Parse(dr["Year"].ToString()),
                         Make = dr["Make"].ToString(),
                            Model = dr["Model"].ToString()

                        };
                return qVeh.ToList();
        }

        public void UpdateVehicle(Vehicle av)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE VEHICLE SET");
            sb.AppendFormat(" Year={0},Make='{1}',Model='{2}' Where Id={3}",
                 av.Year, av.Make, av.Model,av.Id);
            (new DbHelper()).SqlExecute(sb.ToString());
        }
    }
}