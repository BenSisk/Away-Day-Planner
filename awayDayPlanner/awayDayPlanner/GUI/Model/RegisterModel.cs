using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model
{
    public class RegisterModel : IRegisterModel
    {
        public void Submit(User user, Address address, Login login, string confirmPassword)
        {
            Console.WriteLine(address.FirstLine);
            Database.Database.Data.Address.Add(address);
            user.Address = address;
            user.Login = login;
            Database.Database.Data.User.Add(user);

            Database.Database.Data.Login.Add(login);

            Database.Database.Data.SaveChanges();

            var query = from b in Database.Database.Data.User
                        orderby b.firstname
                        select b;

            Console.WriteLine("All users in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.firstname);
            }
        }

        public void Close()
        {
            FormProvider.LoginForm.Show();
            FormProvider.RegisterForm.Hide();
            FormProvider.RegisterForm.Reset();
        }

    }
}
