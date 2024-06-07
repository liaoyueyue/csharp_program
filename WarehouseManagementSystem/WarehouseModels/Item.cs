using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels
{
	public class Item
	{
		public int ItemId { get; set; }
		public string ItemName { get; set; }
		public string ItemDescription { get; set; }
		public string Location { get; set; }
		public int StockQuantity { get; set; }
		public int WarehouseId { get; set; }
		public Item() { }
			
		public Item(int itemId, string itemName, string itemDescription, string location, int stockQuantity, int warehouseId)
		{
			ItemId = itemId;
			ItemName = itemName;
			ItemDescription = itemDescription;
			Location = location;
			StockQuantity = stockQuantity;
			WarehouseId = warehouseId;
		}

		public Item(string itemName, string itemDescription, string location, int stockQuantity, int warehouseId)
		{
			ItemName = itemName;
			ItemDescription = itemDescription;
			Location = location;
			StockQuantity = stockQuantity;
			WarehouseId = warehouseId;
		}

	}
}
