using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRegistration.Models;

namespace UserRegistration.Repository
{
    public interface IUserRepository
    {

        IList<UserRegistrationModel> GetUser();
        UserRegistrationModel GetUserById(int Id);
        void InsertUser(UserRegistrationModel user);
        void UpdateUser(UserRegistrationModel user);
        void DeleteUser(int Id);
        void Save();
        UserRegistrationModel LoginVerification(UserLoginModel userLogin);
    }
}
