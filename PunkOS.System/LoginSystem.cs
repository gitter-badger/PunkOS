using System;

namespace PunkOS.System
{
    public class LoginSystem
    {
        private static Boolean hasInt = false;
        protected static string userlogedin;
        //Not Used
        //private static Hashtable users = new Hashtable();
        //private static Hashtable ranks = new Hashtable();
        //private static Hashtable trys = new Hashtable();
        //=========
        private static string path = @"0:/System/UserData.Sys";
        public static void Init()
        {
            //users.Add("System", "☺");
            //ranks.Add("System", 0);
            if (IO.File.Exists(path))
            {

            }
            else
            {

                IO.File.WriteAllText(path,"System|☺|0;");

            }

            Login("System", "☺");
            addUser("user", "", 1);
            hasInt = true;
        }

        public static string user() { return userlogedin; }

        public static Boolean addUser(string u, string p, int r)
        {

            if (r < getRank(userlogedin))
            {
                //users.Add(u, p);
                //ranks.Add(u, r);
                IO.File.AppendText(path,u + "|" + p + "|" + r + ";");
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void Logout()
        {

            userlogedin = null;

        }

        public static Boolean Login(string u, string p)
        {

            if (true)//users[u].Equals(p))
            {
                userlogedin = u;
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean setRank(string u, int r)
        {
            if (r < getRank(userlogedin))
            {
                if (u != "System")
                {
                    //ranks[u] = r;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
        }

        public static int getRank(string u)
        {
            int ra = 1;
            return ra;
        }


    }

}
