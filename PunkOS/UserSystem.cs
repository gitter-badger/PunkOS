using System;

namespace PunkOS
{
   public class UserSystem
    {
        static UserBase[] users = new UserBase[4];
        private string logedin_user;
        private Boolean logedin = false;
        static int iuser = 0;

        public string User_logedin() { return logedin_user; }

        public Boolean isLogedin() { return logedin; }

        public Boolean Login(string user,string password)
        {
            int i = 0;
            while (i < users.Length)
            {
                if (user == users[i].getusername() )// & users[i].login(password) == true)
                {
                        logedin = true;
                        return true;                  
                }
                i++;
                return false;
            }
            return false;
        }

        public static void Init()
        {

            add(new UserBase("system","notpassword",0));
            add(new UserBase("user", "pass", 1));


        }

        public static void add(UserBase com)
        {
            users[iuser] = com;
            iuser++;
        }

    }
   public class UserBase
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
            if (true) {
                _rank = rank;
            }
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
