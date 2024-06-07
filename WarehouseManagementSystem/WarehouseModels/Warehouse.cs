using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels
{
    public class Warehouse
    {
        public int warehouseId { get; set; }
        public string warehouseName { get; set; }
        public string warehouseAddress { get; set; }
        public int warehouseManager { get; set; }

        public Warehouse() { }

        public Warehouse(int warehouseId, string warehouseName, string warehouseAddress, int warehouseManager)
        {
            this.warehouseId = warehouseId;
            this.warehouseName = warehouseName;
            this.warehouseAddress = warehouseAddress;
            this.warehouseManager = warehouseManager;
        }

		public Warehouse(string warehouseName, string warehouseAddress, int warehouseManager)
		{
			this.warehouseName = warehouseName;
			this.warehouseAddress = warehouseAddress;
			this.warehouseManager = warehouseManager;
		}
	}
}
