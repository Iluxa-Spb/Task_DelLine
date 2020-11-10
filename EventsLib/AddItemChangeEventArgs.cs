using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_DelLine.EventsLib
{
    public class AddItemChangeEventArgs: EventArgs
    {
        public int CarId { get; internal set; }
        public int RepairmanId { get; internal set; }
        public string VehicleMalfunction { get; internal set; }
        public int Cost { get; internal set; }
        public DateTime DateStart { get; internal set; }
        public DateTime DateEnd { get; internal set; }
        public bool IsDone { get; internal set; }

        public AddItemChangeEventArgs(int carId, int repairmanId, string vehicle, int cost, DateTime start, DateTime end, bool done)
        {
            CarId = carId;
            RepairmanId = repairmanId;
            VehicleMalfunction = vehicle;
            Cost = cost;
            DateStart = start;
            DateEnd = end;
            IsDone = done;
        }
    }
}
