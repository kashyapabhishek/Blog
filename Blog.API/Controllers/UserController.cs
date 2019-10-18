using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.InMemoryDataStore;
using Blog.Repository;
using Blog.CoreModel;

namespace Blog.API.Controllers
{
    public class UserController: ControllerBase
    {
        private readonly IUser _User;
        public UserController(IconnectionDB connectionDB)
        {
            _User = new UserInMemory(connectionDB);
        }

        [HttpGet]
        public IEnumerable<User> get(){
            try
            {
                return _User.GetUsers();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}