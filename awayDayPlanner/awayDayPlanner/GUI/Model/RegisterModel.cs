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
        public void Submit(User user, Address address)
        {
            Console.WriteLine(address.FirstLine);
            Database.Database.Data.User.Add(user);
            Database.Database.Data.SaveChanges();
            Database.Database.Data.Address.Add(address);
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
