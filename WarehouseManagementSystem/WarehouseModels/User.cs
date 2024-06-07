using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels
{
    public class User
    {

        int userId {get ;set;}
        string username = String.Empty;
        string password = String.Empty;
        string nickname = String.Empty;
        string contactInformation = String.Empty;

        public User()
        {
        }
        public User(string username, string password, string nickname, string contactInformation)
        {
            this.username = username;
            this.password = password;
            this.nickname = nickname;
            this.contactInformation = contactInformation;
        }
        public User(int userId, string username, string password, string nickname, string contactInformation)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.nickname = nickname;
            this.contactInformation = contactInformation;
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string ContactInformation
        {
            get { return contactInformation; }
            set { contactInformation = value; }
        }

        override public string ToString()
        {
            return string.Format("user:[userId:{0}, username:{1}, password:{2} ,nickname:{3}, contactInformation:{4}]", userId, username, password, nickname, contactInformation);
        }
    }
}
