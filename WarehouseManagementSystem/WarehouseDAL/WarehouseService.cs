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
    public class WarehouseService
    {
        //从配置文件中读取数据库连接字符串
        private readonly string connString = ConfigurationManager.ConnectionStrings["WarehouseManageConnectionString"].ToString();

        /**
         * 添加仓库
        **/
        public int AddWarehouse(Warehouse warehouse)
        {
            int warehouseId = -1;
            string sql = "insert into Warehouse (WarehouseName, WarehouseAddress, WarehouseManager) values (@WarehouseName, @WarehouseAddress, @WarehouseManager); select scope_identity();";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseName", warehouse.warehouseName);
                        cmd.Parameters.AddWithValue("@WarehouseAddress", warehouse.warehouseAddress);
                        cmd.Parameters.AddWithValue("@WarehouseManager", warehouse.warehouseManager);
                        warehouseId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现错误：" + ex.Message);
            }
            return warehouseId;
        }

        /**
         * 删除仓库-通过编号
         **/
        public void DeleteWarehouseById(int id)
        {
            string sql = "delete from Warehouse where WarehouseId = @Id";
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
         * 修改仓库-通过仓库实体类
         **/
        public void UpdateWarehouse(Warehouse warehouse)
        {
            string sql = "update Warehouse set WarehouseName=@WarehouseName, WarehouseAddress=@WarehouseAddress, WarehouseManager=@WarehouseManager where WarehouseId = @WarehouseId; select scope_identity();";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseName", warehouse.warehouseName);
                        cmd.Parameters.AddWithValue("@WarehouseAddress", warehouse.warehouseAddress);
                        cmd.Parameters.AddWithValue("@WarehouseManager", warehouse.warehouseManager);
                        cmd.Parameters.AddWithValue("@WarehouseId", warehouse.warehouseId);
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
         * 获取所有仓库
        **/
        public IList<Warehouse> GetWarehouseAll()
        {
            IList<Warehouse> warehouses = new List<Warehouse>();
            string sql = "select * from Warehouse";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (objReader.Read())
                        {
                            Warehouse warehouse = new Warehouse();
                            warehouse.warehouseId = Convert.ToInt32(objReader["WarehouseId"]);
                            warehouse.warehouseName = Convert.ToString(objReader["WarehouseName"]);
                            warehouse.warehouseAddress = Convert.ToString(objReader["WarehouseAddress"]);
                            warehouse.warehouseManager = Convert.ToInt32(objReader["WarehouseManager"]);
                            warehouses.Add(warehouse);
                        }
                    }
                }
            }
            return warehouses;
        }

        /**
         * 查询仓库名是否存在
        **/
        public bool IsWarehouseNameExists(string name)
        {
            string sql = "select count(*) from Warehouse where WarehouseName = @WarehouseName";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseName", name);
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
         * 获取仓库通过仓库名
        **/
        public IList<Warehouse> GetWarehouseListByName(String name)
        {
            IList<Warehouse> warehouses = new List<Warehouse>();
            string sql = "select * from Warehouse where WarehouseName like @WarehouseName";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@WarehouseName", "%" + name + "%");
                    using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (objReader.Read())
                        {
                            Warehouse warehouse = new Warehouse();
                            warehouse.warehouseId = Convert.ToInt32(objReader["WarehouseId"]);
                            warehouse.warehouseName = Convert.ToString(objReader["WarehouseName"]);
                            warehouse.warehouseAddress = Convert.ToString(objReader["WarehouseAddress"]);
                            warehouse.warehouseManager = Convert.ToInt32(objReader["WarehouseManager"]);
                            warehouses.Add(warehouse);
                        }
                    }
                }
            }
            return warehouses;
        }

        /**
         * 通过仓库编号查询仓库
        **/
        public Warehouse GetWarehouseById(int id)
        {
            Warehouse warehouse = new Warehouse();
            string sql = "select * from Warehouse where WarehouseId = @Id";
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
                            warehouse.warehouseId = Convert.ToInt32(objReader["WarehouseId"]);
                            warehouse.warehouseName = Convert.ToString(objReader["WarehouseName"]);
                            warehouse.warehouseAddress = Convert.ToString(objReader["WarehouseAddress"]);
                            warehouse.warehouseManager = Convert.ToInt32(objReader["WarehouseManager"]);
                        }
                    }
                }
            }
            return warehouse;
        }

    }
}
