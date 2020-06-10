﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRegistration.DBContext;
using UserRegistration.Models;

namespace UserRegistration.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDBContext _appDBContext;

        public UserRepository(ApplicationDBContext applicationDBContext)
        {
            _appDBContext = applicationDBContext;
        }

        public void DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<UserRegistrationModel> GetUser()
        {
            throw new NotImplementedException();
        }

        public UserRegistrationModel GetUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public void InsertUser(UserRegistrationModel user)
        {
            this._appDBContext.UserRegistration.Add(user);
            Save();
        }

        public void Save()
        {
            this._appDBContext.SaveChanges();
        }

        public void UpdateUser(UserRegistrationModel user)
        {
            throw new NotImplementedException();
        }
    }
}
