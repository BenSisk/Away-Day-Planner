using System;
using System.Linq;

namespace awayDayPlanner.GUI.Model
{
    internal class LoginModel : ILoginModel
    {

        public LoginModel() { 
        
        }

        public void createUser()
        {
            throw new NotImplementedException();
        }

        public void deshashPassword()
        {
            throw new NotImplementedException();
        }

        public void getCredentials()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            FormProvider.RegisterForm.Show();
            FormProvider.LoginForm.Hide();
        }

        public void Close()
        {
            FormProvider.LoginForm.Close();
        }

        public void Submit()
        {
            var query = from b in Database.Database.Data.User
                        orderby b.firstname
                        select b;

            Console.WriteLine("All users in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.firstname);
            }
        }

        public void verifyCredentials()
        {
            throw new NotImplementedException();
        }
    }
}