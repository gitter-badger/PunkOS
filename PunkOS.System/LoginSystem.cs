using System;
using System.Collections;
namespace PunkOS.System
{
    public class LoginSystem
    {
        protected static string userlogedin;
        private static Hashtable users = new Hashtable();
        private static Hashtable ranks = new Hashtable();
        private static Hashtable trys = new Hashtable();
        public static void Init()
        {

            users.Add("System", "☺");
            ranks.Add("System", 0);
            Login("System", "☺");
            addUser("user", "", 1);

        }

        public static string user() { return userlogedin; }

        public static Boolean addUser(string u, string p, int r)
        {

            if (r < getRank(userlogedin))
            {
                users.Add(u, p);
                ranks.Add(u, r);
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

            if (users[u].Equals(p))
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
                    ranks[u] = r;
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
            int ra = Convert.ToInt32(ranks[u]);
            return ra;
        }


    }

}
