using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Craps.Models;

namespace Craps.EntityControllers
{
    public interface IUserDataGateway
    {
        UserModel CreateUser(UserModel inputUserModel);
        UserModel GetUser(string userName);
    }
}
