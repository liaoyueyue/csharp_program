using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseModels;
using WarehouseDAL;

namespace WarehouseBLL
{
    public class WarehouseManager
    {
        WarehouseService warehouseService = new WarehouseService();

        /**
         * 添加仓库
        **/
        public string AddWarehouse(Warehouse warehouse)
        {
            //返回信息
            string message = string.Empty;
            try
            {
                if (!warehouseService.IsWarehouseNameExists(warehouse.warehouseName))
                {
                    int id = warehouseService.AddWarehouse(warehouse);
                    if (id > 0)
                    {
                        message = "添加仓库成功";
                    }
                    else
                    {
                        message = "添加仓库失败";
                    }
                }
                else
                {
                    message = "仓库已经存在";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return message;
        }

        /**
        * 删除仓库-通过仓库编号
        **/
        public void DeleteWarehouseById(int id)
        {
            try
            {
                warehouseService.DeleteWarehouseById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        /**
         * 修改仓库
         **/
        public string UpdateWarehouse(Warehouse warehouse)
        {
            //返回信息
            string message = string.Empty;
            try
            {
                Console.WriteLine(warehouse);
                warehouseService.UpdateWarehouse(warehouse);
                message = "仓库修改成功";
            }
            catch (Exception ex)
            {
                message = "仓库修改失败";
                throw new Exception(ex.ToString());
            }
            return message;
        }

        /**
         * 获取所有仓库
        **/
        public IList<Warehouse> GetWarehouseAll()
        {
            try
            {
                return warehouseService.GetWarehouseAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /**
         * 获取仓库通过仓库名
        **/
        public IList<Warehouse> GetWarehouseListByName(String name)
        {
            try
            {
                return warehouseService.GetWarehouseListByName(name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /**
         * 查询仓库-通过仓库编号
         **/
        public Warehouse GetWarehouseById(int id)
        {
            try
            {
                return warehouseService.GetWarehouseById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
       

    }
}
