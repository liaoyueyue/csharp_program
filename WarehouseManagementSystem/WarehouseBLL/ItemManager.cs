using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseModels;

namespace ItemBLL
{
	public class ItemManager
	{
		ItemService itemService = new ItemService();

		/**
         * 添加物品
        **/
		public string AddItem(Item item)
		{
			//返回信息
			string message = string.Empty;
			try
			{
				if (!itemService.IsItemNameExists(item.ItemName))
				{
					int id = itemService.AddItem(item);
					if (id > 0)
					{
						message = "添加物品成功";
					}
					else
					{
						message = "添加物品失败";
					}
				}
				else
				{
					message = "物品已经存在";
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
			return message;
		}

		/**
        * 删除物品-通过物品编号
        **/
		public void DeleteItemById(int id)
		{
			try
			{
				itemService.DeleteItemById(id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
		/**
         * 修改物品
         **/
		public string UpdateItem(Item item)
		{
			//返回信息
			string message = string.Empty;
			try
			{
				Console.WriteLine(item);
				itemService.UpdateItem(item);
				message = "物品修改成功";
			}
			catch (Exception ex)
			{
				message = "物品修改失败";
				throw new Exception(ex.ToString());
			}
			return message;
		}

		/**
         * 获取所有物品
        **/
		public IList<Item> GetItemAll()
		{
			try
			{
				return itemService.GetItemAll();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		/**
         * 获取物品通过物品名
        **/
		public IList<Item> GetItemListByName(String name)
		{
			try
			{
				return itemService.GetItemListByName(name);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		/**
         * 查询物品-通过物品编号
         **/
		public Item GetItemById(int id)
		{
			try
			{
				return itemService.GetItemById(id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
	}
}
