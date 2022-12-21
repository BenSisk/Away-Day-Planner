using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;

namespace awayDayPlanner.Lib.Factory
{
    public class Login : IFactory, ILoginModel
    {
        [Key]
        public int loginID { get; set; }
        [Required] public String Username { get; set; }
        [Required] public String Password { get; set; }

        private static Login instance = null;
        private static readonly object padlock = new object();


        public static Login getInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Login();
                    }
                    return instance;
                }
            }
        }

        private Boolean UserExists()
        {
            return Database.Database.Data.Login.Any(c => c.Username == this.Username);
        }

        public void verifyCredentials()
        {
            if (this.Username.Length > 3 && this.Username.Length <= 50)
            {
                if (this.UserExists())
                    Console.WriteLine("User exists");
                else
                    Console.WriteLine("USer doesn't exist");
            }
            else
            {
                Console.WriteLine("Username must be between 3 and 50 characters");
            }
        }

        public void createUser()
        {

        }

        private void deshashPassword()
        {

        }

        void ILoginModel.deshashPassword()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Submit()
        { throw new NotImplementedException(); }
    }
}
