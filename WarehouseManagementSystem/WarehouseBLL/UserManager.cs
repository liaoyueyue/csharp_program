using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseModels;
using WarehouseDAL;

namespace WarehouseBLL
{
    public class UserManager
    {
        UserService userService = new UserService();

        /**
         * 添加用户信息
        **/
        public string AddUser(User user)
        {
            //返回信息
            string message = string.Empty;
            try
            {
                if (!userService.IsUsernameExists(user.Username))
                {
                    int id = userService.AddUser(user);
                    if (id > 0)
                    {
                        message = "添加用户成功";
                    }
                    else
                    {
                        message = "添加用户失败";
                    }
                }
                else 
                {
                    message = "用户名已经存在";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return message;
        }
        /**
         * 获取所有用户信息
        **/
        public IList<User> GetUserALL()
        {
            try
            {
                return userService.GetUserAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /**
         * 获取用户信息通过用户名
        **/
        public IList<User> GetUserListByUsername(String username)
        {
            try
            {
                return userService.GetUserListByUsername(username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /**
         * 查询用户信息-通过用户编号
         **/
        public User GetUserById(int id)
        {
            try
            {
                return userService.GetUserById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        /**
         * 删除用户信息-通过用户编号
         **/
        public void DeleteUserById(int id)
        {
            try
            {
                userService.DeleteUserById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        /**
         * 修改用户信息-通过用户实体类
         **/
        public string UpdateUser(User user)
        {
            //返回信息
            string message = string.Empty;
            try
            {
                Console.WriteLine(user);
                userService.UpdateUser(user);
                message = "用户修改成功";
            }
            catch (Exception ex)
            {
                message = "用户修改失败";
                throw new Exception(ex.ToString());
            }
            return message;
        }


    }
}
