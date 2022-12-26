﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model
{
    public interface ILoginModel
    {
        void createUser();

        void hashPassword();

        void Register();

        void Close();

        void Submit(string username, string password);
    }
}