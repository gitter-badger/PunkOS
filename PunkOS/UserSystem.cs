using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS
{
    class UserSystem
    {
        static UserBase[] users = new UserBase[4];
        private string logedin_user;
        private Boolean logedin = false;
        static int iuser = 0;

        public static Boolean Login(string user,string password)
        {

            for (int i = 0; i < users.Length; i++)
            {
                if (user == users[i].getusername())
                {
                    if (users[i].login(password)  == true)
                    {
                        return true;
                    }
                    return false;

                }
                return false;
            }
            return false;

        }

        public static void Init()
        {

            add(new UserBase("system","♥☺☻☺♥",0));
            

        }

        public static void add(UserBase com)
        {
            users[iuser] = com;
            iuser++;
        }

    }
    class UserBase
    {
        int _rank ;
        string _username = "";
        string _password = "";
        public UserBase(string username, string password, int rank)
        {
            _rank = rank;
            _username = username;
            _password = password;

        }

        public Boolean login( string password)
        {
            if (password == _password)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public int getrank()
        {
            return _rank;
        }
        public void setrank(int rank)
        {
            _rank = rank;
        }

        public string getusername()
        {
            return _username;
        }
        public void setusername(string username)
        {
            _username = username;
        }

    }
}
