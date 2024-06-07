using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WarehouseModels;

namespace WarehouseDAL
{
    public class UserService
    {

        //从配置文件中读取数据库连接字符串
        private readonly string connString = ConfigurationManager.ConnectionStrings["WarehouseManageConnectionString"].ToString();

        /**
         * 添加用户信息
        **/
        public int AddUser(User user)
        {
            int userId = -1;
            string sql = "insert into [User] (Username, [Password], Nickname, ContactInformation) values (@Username, @Password, @Nickname, @ContactInformation); select scope_identity();";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Nickname", user.Nickname);
                        cmd.Parameters.AddWithValue("@ContactInformation", user.ContactInformation);
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine("出现错误：" + ex.Message);
            }
            return userId;
        }

        /**
         * 查询用户名是否存在
        **/
        public bool IsUsernameExists(string username)
        {
            string sql = "select count(*) from [User] where Username = @Username";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
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
         * 获取所有用户信息
        **/
        public IList<User> GetUserAll()
        {
            IList<User> users = new List<User>();
            string sql = "select * from [User]";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (objReader.Read())
                        {
                            User user = new User();
                            user.UserId = Convert.ToInt32(objReader["UserId"]);
                            user.Username = Convert.ToString(objReader["Username"]);
                            user.Password = Convert.ToString(objReader["Password"]);
                            user.Nickname = Convert.ToString(objReader["Nickname"]);
                            user.ContactInformation = Convert.ToString(objReader["ContactInformation"]);
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

        /**
         * 获取用户信息通过用户名
        **/
        public IList<User> GetUserListByUsername(String username)
        {
            IList<User> users = new List<User>();
            string sql = "select * from [User] where Username like @Username";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", "%"+ username + "%");
                    using (SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (objReader.Read())
                        {
                            User user = new User();
                            user.UserId = Convert.ToInt32(objReader["UserId"]);
                            user.Username = Convert.ToString(objReader["Username"]);
                            user.Password = Convert.ToString(objReader["Password"]);
                            user.Nickname = Convert.ToString(objReader["Nickname"]);
                            user.ContactInformation = Convert.ToString(objReader["ContactInformation"]);
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

        /**
         * 通过用户编号查询用户信息
        **/
        public User GetUserById(int id)
        {
            User user = new User();
            string sql = "select * from [User] where UserId = @Id";
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
                            user.UserId = Convert.ToInt32(objReader["UserId"]);
                            user.Username = Convert.ToString(objReader["Username"]);
                            user.Password = Convert.ToString(objReader["Password"]);
                            user.Nickname = Convert.ToString(objReader["Nickname"]);
                            user.ContactInformation = Convert.ToString(objReader["ContactInformation"]);
                        }
                    }
                }
            }
            return user;
        }

        /**
         * 删除用户信息-通过用户编号
         **/
        public void DeleteUserById(int id)
        {
            string sql = "delete from [User] where UserId = @Id";
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
         * 修改用户信息-通过用户实体类
         **/
        public void UpdateUser(User user)
        {
            string sql = "update [User] set Username=@Username, [Password]=@Password, Nickname=@Nickname, ContactInformation=@ContactInformation where UserId = @UserId; select scope_identity();";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Nickname", user.Nickname);
                        cmd.Parameters.AddWithValue("@ContactInformation", user.ContactInformation);
                        cmd.Parameters.AddWithValue("@UserId", user.UserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现错误：" + ex.Message);
            }
        }

    }
}
