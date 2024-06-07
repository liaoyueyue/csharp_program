using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseModels;

namespace WarehouseDAL
{
	public class ItemService
	{
		//从配置文件中读取数据库连接字符串
		private readonly string connString = ConfigurationManager.ConnectionStrings["WarehouseManageConnectionString"].ToString();
		/**
         * 添加物品
        **/
		public int AddItem(Item item)
		{
			int itemId = -1;
			string sql = "insert into Item (ItemName, ItemDescription, Location, StockQuantity, WarehouseId) values (@ItemName, @ItemDescription, @Location, @StockQuantity, @WarehouseId); select scope_identity();";
			try
			{
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
						cmd.Parameters.AddWithValue("@ItemDescription", item.ItemDescription);
						cmd.Parameters.AddWithValue("@Location", item.Location);
						cmd.Parameters.AddWithValue("@StockQuantity", item.StockQuantity);
						cmd.Parameters.AddWithValue("@WarehouseId", item.WarehouseId);
						itemId = Convert.ToInt32(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("出现错误：" + ex.Message);
			}
			return itemId;
		}

		/**
         * 删除物品-通过编号
         **/
		public void DeleteItemById(int id)
		{
			string sql = "delete from Item where ItemId = @Id";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/**
         * 修改物品-通过物品实体类
         **/
		public void UpdateItem(Item item)
		{
			string sql = "update Item set ItemName=@ItemName, ItemDescription=@ItemDescription, Location=@Location, StockQuantity=@StockQuantity, WarehouseId=@WarehouseId where ItemId = @ItemId; select scope_identity();";
			try
			{
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
						cmd.Parameters.AddWithValue("@ItemDescription", item.ItemDescription);
						cmd.Parameters.AddWithValue("@Location", item.Location);
						cmd.Parameters.AddWithValue("@StockQuantity", item.StockQuantity);
						cmd.Parameters.AddWithValue("@WarehouseId", item.WarehouseId);
						cmd.Parameters.AddWithValue("@ItemId", item.ItemId);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("出现错误：" + ex.Message);
			}
		}

		/**
         * 获取所有物品
        **/
		public IList<Item> GetItemAll()
		{
			IList<Item> items = new List<Item>();
			string sql = "select * from Item";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
					{
						while (objReader.Read())
						{
							Item item = new Item();
							item.ItemName = Convert.ToString(objReader["ItemName"]);
							item.ItemDescription = Convert.ToString(objReader["ItemDescription"]);
							item.Location = Convert.ToString(objReader["Location"]);
							item.StockQuantity = Convert.ToInt32(objReader["StockQuantity"]);
							item.WarehouseId = Convert.ToInt32(objReader["WarehouseId"]);
							item.ItemId = Convert.ToInt32(objReader["ItemId"]);
							items.Add(item);
						}
					}
				}
			}
			return items;
		}

		/**
         * 查询物品名是否存在
        **/
		public bool IsItemNameExists(string name)
		{
			string sql = "select count(*) from Item where ItemName = @ItemName";
			try
			{
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@ItemName", name);
						int count = Convert.ToInt32(cmd.ExecuteScalar());
						return count > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("出现错误：" + ex.Message);
			}
			return true;
		}

		/**
         * 获取物品通过物品名
        **/
		public IList<Item> GetItemListByName(String name)
		{
			IList<Item> items = new List<Item>();
			string sql = "select * from Item where ItemName like @ItemName";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@ItemName", "%" + name + "%");
					using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
					{
						while (objReader.Read())
						{
							Item item = new Item();
							item.ItemName = Convert.ToString(objReader["ItemName"]);
							item.ItemDescription = Convert.ToString(objReader["ItemDescription"]);
							item.Location = Convert.ToString(objReader["Location"]);
							item.StockQuantity = Convert.ToInt32(objReader["StockQuantity"]);
							item.WarehouseId = Convert.ToInt32(objReader["WarehouseId"]);
							item.ItemId = Convert.ToInt32(objReader["ItemId"]);
							items.Add(item);
						}
					}
				}
			}
			return items;
		}

		/**
         * 通过物品编号查询物品
        **/
		public Item GetItemById(int id)
		{
			Item item = new Item();
			string sql = "select * from Item where ItemId = @Id";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Id", id);
					using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
					{
						while (objReader.Read())
						{
							item.ItemName = Convert.ToString(objReader["ItemName"]);
							item.ItemDescription = Convert.ToString(objReader["ItemDescription"]);
							item.Location = Convert.ToString(objReader["Location"]);
							item.StockQuantity = Convert.ToInt32(objReader["StockQuantity"]);
							item.WarehouseId = Convert.ToInt32(objReader["WarehouseId"]);
							item.ItemId = Convert.ToInt32(objReader["ItemId"]);
						}
					}
				}
			}
			return item;
		}

	}
}
